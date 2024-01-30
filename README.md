<img src="logo.png" width="300"/>

# fUML/PSCS Reference Implementation for C#
This software is an open source reference implementation of the *Semantics of a Foundational Subset for Executable UML Models* (fUML) and *Precise Semantics of UML Composite Structures* (PSCS)
specifications by the *Object Management Group* (OMG) (see [fUML](https://www.omg.org/spec/FUML/1.5/About-FUML) and [PSCS](https://www.omg.org/spec/PSCS/1.2/About-PSCS)). 
The fUML implementation of this software is based on the Java fUML reference implementation developed by
*Model Driven Solutions* (see [https://github.com/ModelDriven/fUML-Reference-Implementation](https://github.com/ModelDriven/fUML-Reference-Implementation))

## Licensing
For licensing information, please see the [LICENSE.md](https://github.com/HammerMaximilian/fUML-CSharp/blob/master/LICENSE) file.

## Prerequisites
For detailed information, please see the [User Guide](fUML-C#_User_Guide.pdf) section *1. Prerequisites*.
### 1. Required Software
* *.NET Framework* (at least version 6.0)
* *Microsoft Visual Studio*[^1]
[^1]: For non-developing users Microsoft Visual Studio is only used for compilation. It is also possible to build C# projects from command line using *msbuild.exe* but for convenience it is suggested to use Microsoft Visual Studio.
### 2. Recommended but optional Software
* *Eclipse Modeling Tools* for creating UML models
  * *Java Runtime Environment* is required for Eclipse 
* *Eclipse Papyrus* for more sophisticated and graphical modeling of UML models
* *Acceleo* to be able to use the code generator for executable models

## Setup
For detailed information, please see the [User Guide](fUML-C#_User_Guide.pdf) section *2. Setup*.
### 1. Setting up Visual Studio
* Import fUML-C# root solution *fUML-CSharp.sln* in Visual Studio

## Building
For detailed information, please see the [User Guide](fUML-C#_User_Guide.pdf) section *3. Build*.
* Build dynamic libraries for *uml*, *fuml* *pscs* (**in that order**) Visual Studio or simply build the whole solution
* Depending on your preferences and needs, build debug, release or both

## Usage
For detailed information, please see the [User Guide](fUML-C#_User_Guide.pdf) section *4. Usage*.
### 1. Creating executable models using source code
* Create new C# project (see `"<fUML-C#-rootdir>\fUML-CSharp\examples\helloworld"` as a reference project)
  * NOTE: it is suggested to store user-defined source code projects in common directory `"<fUML-C#-rootdir>\fUML-CSharp\usersrc"`
  * The *usersrc* directory may contain arbitrary nested subdirectories
* Add required assemblies for uml, fuml and pscs to your project's references
* Create a `<model-name>Environment` class by deriving from class `fuml.environment.Environment`
* Create a `<model-name>Model` class by deriving from class `uml.environment.InMemoryModel` (this class will contain all of your model elements)
* Create a class containing a main method and call `<model-name>Environment.Instance().Execute("<behavior-name>");` for each behavior you want to execute in subsequent order
* Build project and run executable 
### 2. Generating executable models from *.uml* models (*Acceleo* plugin for Eclipse has to be installed)
* Import fUML-C# root project
* Import nested project *generator* within fUML-C# root project
* Create new *.uml* model with a modeling tool of your choice (*Eclipse Papyrus* is suggested)
  * NOTE: it is suggested to store user-defined models in common directory `"<fUML-C#-rootdir>\fUML-CSharp\usermodels"`
  * The *usermodels* directory may contain arbitrary nested subdirectories
* Navigate to file `\generator\src\fuml.generator.main\generate.mtl` in the project explorer
* Right click `generate.mtl` and choose `Run as`-->`Run configurations...`
* Configure and run Acceleo Application accordingly:
  *  Choose `fuml.generator.main.Generate`
  *  Choose your model file
  *  Choose a target directory for the generated source code (`"<fUML-C#-rootdir>\fUML-CSharp\usersrc\<model-name>"` is suggested)
* Open newly generated C# project in Visual Studio and build executable(s)
* Run executable from command line using `<executable-name> <behavior-name> [<behavior-name> <behavior-name> <behavior-name> <...>]`
