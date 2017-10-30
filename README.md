# Name Sorter

A project that sorts a list of names of the form:

```
Firstname Lastname
Firstname MiddleName Lastname
Firstname Lastname
```

The names are sorted into alphabetical order by last name, then given names

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Installing

If you don't have it installed already you should download [.NET core](https://www.microsoft.com/net/download/core "Download .NET core").

Once this is done you can pick whatever development environment you'd prefer. I used Visual Studio Code, but you could just as easily use the command line or Visual Studio 2017.

For Visual Studio Code, you can then use the following steps in the command line to build and test the project:

```
cd ./name-sorter
dotnet restore
dotnet publish -c Release -r win10-x64
cd ../name-sorter-tests
dotnet restore
dotnet xunit
```

The publish step will vary depending on your operating system.

Once this is complete you can navigate to the program name-sorter in bin\Release\netcoreapp2.0\win10-x64 or similar, and run the .exe

```
E:\Example>name-sorter ./unsorted-names-list.txt
```

## Built With

* [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/ ".NET Core docs") - The framework used
* [Visual Studio Code](https://code.visualstudio.com/docs "VS Code docs") - Development environment

## Authors

* **Evelyne Berger-Uichanco** - [Evangelinexx](https://github.com/Evangelinexx)

## Acknowledgments

* Created for a coding assessment by [GlobalX](https://globalx.com.au/)
