param(
    [string] $ProjectDir = $PSScriptRoot
)

#	this must be run manually when the build number is to be increased for the reasons outline below.

# Cannot be called from the Pre-Build Event because it modifies the project file, which is locked once the build starts
# It also cannot be called from the post-build event because this project has multiple targets so the build runs multiple 
#		times which results in bumping the build number once for each target. To make things a little worse, each of the target
#		builds also runs in parallel so there is no reliable way of tagging the "first" target build. 

# make no attempt to automate this into a local build. Do not give in to the dark side.


function WriteStatusMessage([string] $msg) {
    Write-Host "Update-BuildNumber: $msg"    
}

WriteStatusMessage "Project Folder: $ProjectDir"
Pushd "$ProjectDir"


function MakeIntIfPossible([string] $value) {
    [Int32] $result = 0
    if ([Int32]::TryParse($value, [ref] $result)) {
        $result
        return
    }
    $value
}


function ParseVersionNumber([string] $versionValue) {
    $verParts = "$versionValue".Split('.')

    $verMajor = 0
    if ($verParts.Length -gt 0) { $verMajor = MakeIntIfPossible $verParts[0] }

    $verMinor = 0
    if ($verParts.Length -gt 1) { $verMinor = MakeIntIfPossible $verParts[1] }

    $verRevision = 0
    if ($verParts.Length -gt 2) { $verRevision = MakeIntIfPossible $verParts[2] }

    $verBuild = 0
    if ($verParts.Length -gt 3) { $verBuild = MakeIntIfPossible $verParts[3] }

    $obj = New-Object psobject
    $obj | Add-Member -MemberType NoteProperty -Name "Text" -Value ""
    $obj | Add-Member -MemberType NoteProperty -Name "Major" -Value $verMajor
    $obj | Add-Member -MemberType NoteProperty -Name "Minor" -Value $verMinor
    $obj | Add-Member -MemberType NoteProperty -Name "Revision" -Value $verRevision
    $obj | Add-Member -MemberType NoteProperty -Name "Build" -Value $verBuild
    $obj | Add-Member -MemberType NoteProperty -Name "Segments" -Value $verParts

    $obj
}


function FormatVersionNumber([psobject] $value) {
    $segments = @($value.Major, $value.Minor, $value.Revision, $value.Build)
    $value.Text = [string]::Join(".", $segments)
}



function GetVersionInfo([System.Xml.XmlDocument] $xmlDocument, [System.Xml.XmlElement] $parentNode) {
	$verNode = GetNode $doc $parentNode "AssemblyVersion"

	$verValue = $verNode.innerText

    WriteStatusMessage "Found version '$($verValue)' in project node: AssemblyVersion"

    $versionInfo = ParseVersionNumber $verValue
    
    $versionInfo.Build++

    FormatVersionNumber $versionInfo

    $versionInfo
}


function GetNode([System.Xml.XmlDocument] $xmlDocument, [System.Xml.XmlElement] $parentNode, [string] $nodeName) {
    $node = $parentNode.SelectSingleNode($nodeName)
    if ($node -eq $null) {
        $node = $xmlDocument.CreateElement($nodeName)
        $parentNode.AppendChild($versionNode)
        $node = $parentNode.SelectSingleNode($nodeName)
    }
    $node
}


function AddVersionToProjectFile() {
    $projectFiles = [System.IO.Directory]::GetFiles($ProjectDir, "*.*proj", [System.IO.SearchOption]::TopDirectoryOnly)
    if ($projectFiles -eq $null -or $projectFiles.length -lt 1) {
        throw [System.Exception]  "No project files found to modify"
    }

    if ($projectFiles.length -gt 1) {
        throw [System.Exception]  "Too many project files found to modify"
    }


    $projFile =$projectFiles[0]

    $doc = [xml](Get-Content $projFile)

    #using xml
    $groupNode = $doc.SelectSingleNode("/Project/PropertyGroup[TargetFrameworks|TargetFramework]")
    if ($groupNode -eq $null) { 
        throw [System.Exception] "Unable to identify proper parent node for version in Project file '$projFile'"
    }

	$version = GetVersionInfo $doc $groupNode

    $versionNode = GetNode $doc $groupNode "Version"
    $versionNode.InnerText = $version.Text

    $versionNode = GetNode $doc $groupNode "AssemblyVersion"
    $versionNode.InnerText = $version.Text

    $versionNode = GetNode $doc $groupNode "FileVersion"
    $versionNode.InnerText = $version.Text

	WriteStatusMessage "Setting Build Number: $($version.Text)"

    $doc.Save($projFile)
}

try {
	AddVersionToProjectFile
} catch {
	Write-Error $_
} finally {
	Popd
}