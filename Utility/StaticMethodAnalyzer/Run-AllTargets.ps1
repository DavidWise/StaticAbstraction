
function RunFile([string] $parentPath) {
    $parentFolder = get-item $parentPath
    Write-Host "Running: $($parentFolder.Name)\" -NoNewline
    $targetFile = join-path $parentFolder.FullName "StaticMethodAnalyzer.exe"
    if (-not (Test-Path $targetFile)) {
        $targetFile = join-path $parentFolder.FullName "StaticMethodAnalyzer.dll"
    }

    $targetInfo = Get-Item $targetFile

    Write-Host "$($targetInfo.Name)..." -NoNewline

    pushd $targetInfo.DirectoryName
    if ($targetinfo.Extension -like ".exe") {
        & ".\$($targetInfo.Name)"
    } else {
        $proc = Start-Process -FilePath "dotnet.exe" -ArgumentList @("run", ".\$($targetInfo.Name)") -Wait
    }
    popd

    Write-Host "done"
}

$projectRoot = get-item $psscriptroot

Write-Output "ProjectRoot: $($projectRoot.FullName)"

$binRoot = get-item (Join-Path $projectRoot.FullName "bin\debug")

$fileNames = @("StaticMethodAnalyzer.exe", "StaticMethodAnalyzer.dll")

$allFolders = Get-ChildItem -LiteralPath $binRoot.FullName -Filter "*StaticMethodAnalyzer.???" -Recurse | where { $_.Extension -eq ".exe" -or $_.Extension -eq ".dll"} | % { $_.DirectoryName } | Select -Unique | sort


$allFolders |  % {
    RunFile $_
}





