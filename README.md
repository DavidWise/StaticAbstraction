# StaticAdbstraction
A library that wraps the static methods on common objects in the System.IO 

This is intended to alleviate developers from having to figure out and code ways around testing objects that use those static methods


This is meant solely to wrapper commonly used objects that provide untestable static methods so that they can be tested.
All objects are direct matches to their static-bound brethren, use the same paramters, have the same overloads and so forth.  Each method/property is meant to be as lightweight as possible with the least amount of extra code.  
Most moths and wrappers are direct wrappers around the relevant method/property


In order to use this, you will have to change your coding to use the classes here instead, either as direct object creations or as 



i.e.. instead of doing File.Delete("somefilename")

you would do:

_file.Delete("somefilename");

where _file was declared as an IFile and either created in a constructor directly or injected via DI.


This allows unit tests to properly mock out the .Delete() command so that it never attempts actual disk IO



# Mocks

using StaticAbstraction.IO.Mocks;

There are implementations of the common interfaces below.  These are meant to be building blocks to be used when stubbing out method results in unit tests.  In addition
to implementing the interface, they also offer setters for all properties so that values can be mocked out as required.

	IDirectoryInfo
	IFileInfo
	IFileSystemInfo

All methods either do nothing or return `NULL` if the method returned a value.  They are all virtual so that they can be further subclassed if needed.


# Still TODO
- override basic object methods such as ToString and Equals() (more investigation needed)
- Implement ISerializable 


