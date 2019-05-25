# StaticAbstraction
A library that wraps the static methods on common objects in the System.IO 

This is intended to alleviate developers from having to figure out and code ways around testing objects that use those static methods


This is meant solely to wrapper commonly used objects that provide untestable static methods so that they can be tested.
All objects are direct matches to their static-bound brethren, use the same paramters, have the same overloads and so forth.  Each method/property is meant to be as lightweight as possible with the least amount of extra code.  
Most moths and wrappers are direct wrappers around the relevant method/property


In order to use this, you will have to change your coding to use the classes here instead, either as direct object creations or as 



i.e.. instead of doing 

`File.Delete("somefilename");`

you would do:

`_file.Delete("somefilename");`

where `_file` was declared as an `IFile` and either created in a constructor directly or injected via DI.


This allows unit tests to properly mock out the .Delete() command so that it never attempts actual disk IO

These objects will also wrapper annoying to mock results from their methods (i.e. FileInfo, DirectoryInfo, Assembly) so that both the method and the results can be easily tested


## Interfaces and classes
each of the common interfaces used in this module have a single implementor in the event that you need to instantiate them directly

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



# Mocks

using StaticAbstraction.IO.Mocks;

There are implementations of the common interfaces below.  These are meant to be building blocks to be used when stubbing out method results in unit tests.  In addition
to implementing the interface, they also offer setters for all properties so that values can be mocked out as required.

|Interface|Mock|
|-|-|
|IDirectoryInfo|MockDirectoryInfo|
|IFileInfo|MockFileInfo|
|IFileSystemInfo|MockDFileSystemInfo|
|IDriveInfoDetails|MockDriveInfoDetails|
|IAssemblyInstance|MockAssemblyInstance|

All methods/properties on the mocks either do nothing or return the default for whatever type is normally returned (i.e. NULL for objects, false for bool, etc)
  They are all virtual so that they can be further subclassed if needed.

# Notes
- I have attempted to make the wrapper classes as lightweight as possible since some of this code will be in the actually final application but certain methods are going to be heavier.  Most notably are those that need to convert large quantities of the wrapped object (i.e. FileInfo) into same sized arrays of wrapper objects (IFileInfo)

# Still TODO
- override basic object methods such as ToString and Equals() (more investigation needed)
- Implement ISerializable 


# Suggestions
This is still in the very, very early stages so if you use the library and find something else that would be handy, please log an issue with the details

