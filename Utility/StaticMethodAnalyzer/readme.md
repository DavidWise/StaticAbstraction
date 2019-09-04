# Static Method Analyzer

### What this does
This generates the method and propery signatures for the objects that Static Abstraction wrappers. It does this for each of the supported frameworks\

### How it works
Thanks to the wonders of multiple targetted frameworks, when the app is built, it builds a framework-specific copy of itself in the /bin/debug.../ paths

- Each EXE needs to be run manually (.net core dlls need to run with `dotnet [dllname]` )
- Each EXE will generate signature summaries in the Output folder in subfolders based on the framework that was used to build that EXE


## Notes
- This is just a quick utility app that should only be needed when new revs of the framework are out
- It is a very manual process
- Beyond Compare is needed for comparing the signature files between the different frameworks

