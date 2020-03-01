# StaticAbstraction
#### What
A light-weight library that wraps the static methods on common objects in the .Net Framework and .Net Core 
so that components that would normally rely on these otherwise unmockable methods can be safely unit tested. 

The objects that are wrapped by this library include:
- System.Console
- System.DateTime    
- System.Environment
- System.IO.Directory
- System.IO.DirectoryInfo
- System.IO.DriveInfo
- System.IO.File
- System.IO.FileInfo
- System.IO.FileSystemInfo
- System.IO.Path
- System.Reflection.Assembly

The methods and properties on all of the wrapper objects are, in nearly all cases, direct wrappers of the static 
functionality.  The only place where more complex work is done is where the wrapped method returns an array of 
otherwise wrapped objects.  In those cases, there is extra work to wrap the individual array items.

##### Special note for .Net Core
If you are using .Net Core, you might want to look at 
the [IFileProvider](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/file-providers?view=aspnetcore-3.0) interface 
to see if it provides the functionality you need without requiring a third-pary library like this.


#### Why
This is intended to alleviate developers from having to figure out and code ways around testing objects that use those static methods.  Since most of 
those solutions involve creating custom code just like this, I figured maybe it should already exist in a reusable form.

This is meant solely to wrapper commonly used objects that provide untestable static methods so that they can be tested.
All objects are direct matches to their static-bound brethren, use the same paramters, have the same overloads and so forth.  Each method/property is meant to be as lightweight as possible with the least amount of extra code.  


#### How
In order to use this, you will have to change places in your existing code so that it uses 
the classes and interfaces defined here instead of the static methods provided by the 
framework, either as direct object creations or as objects created via Dependency Injection.


i.e.. instead of doing 

```C#
    File.Delete("somefilename");
```
you would do:
```C#
    _file.Delete("somefilename");
```

where `_file` was declared as an `IFile` and either created in a constructor directly or injected via dependency injection (DI).

This allows unit tests to properly mock out the .Delete() command so that it never attempts actual disk IO

Speaking of Dependency Injection, you will also have to configure your DI of choice to inject these classes where needed.  I've included the list of classes, interfaces and such in the next section.


These objects will also wrapper _annoying to mock_ results from their methods (i.e. FileInfo, DirectoryInfo, Assembly) so that both the method and the results can be easily tested

Additionally, most of the objects that are wrapped by this code also have a new extension method `ToStaticAbstraction()` that will create an instance of the abstraction class.



## Interfaces and classes
Each of the common interfaces used in this module have a single implementor in the event that you need to instantiate them directly

|interface|class|Wraps|
|---|---|---|
|IStaticAbstraction|StAbWrapper|N/A - allows access to all abstractions|
|IFile|StAbFile|System.IO.File|
|IPath|StAbPath|System.IO.Path|
|IDirectory|StAbDirectory|System.IO.Directory|
|IDriveInfo|StAbDriveInfo|System.IO.DriveInfo|
|IConsole|StAbConsole|System.Console|
|IDateTime|StAbDateTime|System.DateTime|
|IAssembly|StAbAssembly|System.Reflection.Assembly|
|IEnvironment|StAbEnvironment|System.Environment|

## Special interfaces and classes
These classes wrap otherwise hard or annying to mock object returned from the static methods wrappered above and are not generally created directly, though certainly can be if needed.

In the example:
```
public void MagicMethod(IDirectory directory) {
    var allFiles = directory.GetFiles(somerandompath)
}
```
The content of `allFiles` would be an array of `IFileInfo` objects, rather than the array of `FileInfo` objects that the `System.IO.Directory` call would normally return.

|interface|class|Wraps|
|---|---|---|
|IFileInfo|StAbFileInfo|System.IO.FileInfo|
|IDirectoryInfo|StAbDirectoryInfo|System.IO.DirectoryInfo|
|IAssemblyInstance|StAbAssemblyInstance|System.Reflection.Assembly|


# Mocks
There are implementations of the common interfaces below.  These are meant to be building blocks to be used when stubbing out method results in unit tests.  In addition
to implementing the interface, they also offer:
- setters for all properties so that values can be mocked out as required.
- all properties and methods are virtual so they can easily be overridden in a subclass if needed
- methods/properties either do nothing or return the default for whatever type is normally returned (i.e. NULL for objects, false for bool, etc)


|Interface|Mock|Namespace|
|-|-|-|
|IConsole|MockConsole|StaticAbstraction.Mocks|
|IEnvironment|MockEnvironment|StaticAbstraction.Mocks|
|IDirectoryInfo|MockDirectoryInfo|StaticAbstraction.IO.Mocks|
|IFileInfo|MockFileInfo|StaticAbstraction.IO.Mocks|
|IFileSystemInfo|MockDFileSystemInfo|StaticAbstraction.IO.Mocks|
|IDriveInfoDetails|MockDriveInfoDetails|StaticAbstraction.IO.Mocks|
|IAssemblyInstance|MockAssemblyInstance|StaticAbstraction.Reflection.Mocks|


The interfaces themselves can easily be stubbed out via `NSubstitute` or similar but these offer the convenience of simple object construction.

In the interest of completeness, there is also a top-level accessor object that can be injected that provides properties that will 

|Interface|Class|
|-|-|
|IStaticAbstraction|StAbWrapper|




# Supported .Net versions
At present, the library builds to support the following .Net versions and matches methods/properties with the version targetted.  

This means that even though .Net Core 3.0 supports the [`Path.Join(string[])`](https://docs.microsoft.com/en-us/dotnet/api/system.io.path.join?view=netcore-3.0#System_IO_Path_Join_System_String___) method, that method will not be visible on the wrappers if you are targeting
.Net Core 2.2 or earlier.

- .Net Core 3.1
- .Net Core 3.0
- .Net Core 2.2
- .Net Standard 2.1
- .Net Standard 2.0
- .Net Framework 4.8
- .Net Framework 4.7
- .Net Framework 4.6
- .Net Framework 4.5

# Notes
- I have attempted to make the wrapper classes as lightweight as possible since some of this code will be in the actually final application but certain methods are going to be heavier.  Most notably are those that need to convert large quantities of the wrapped object (i.e. FileInfo) into same sized arrays of wrapper objects (IFileInfo)

# Still TODO
- isolate and fully support building to .Net Standard 2.1
- override basic object methods such as ToString and Equals() (more investigation needed)
- Implement ISerializable 

# Suggestions
This is still in the early stages so if you use the library and find 
something else that would be handy, please [log an issue](https://github.com/DavidWise/StaticAbstraction/issues/new/choose) with the details



