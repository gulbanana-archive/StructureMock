This repository demonstrates a bug encountered in the .NET Core tooling.

If you build this solution in Visual Studio 2015 Update 3, the project Lib.Web will always be recompiled with a messaging alleging inputs were modified. If any other project or reference is removed, this stops occurring and the rebuilds will be correctly skipped.

**Build Log**
```
1>------ Build started: Project: Lib.Web, Configuration: Debug Any CPU ------
1>  C:\Program Files\dotnet\dotnet.exe build "C:\Users\banana\Documents\agile\StructureMock\Lib.Web" --configuration Debug --no-dependencies
1>  Project Lib.Web (.NETStandard,Version=v1.6) will be compiled because inputs were modified
1>  Compiling Lib.Web for .NETStandard,Version=v1.6
1>  Compilation succeeded.
1>      0 Warning(s)
1>      0 Error(s)
1>  Time elapsed 00:00:00.6308656
1>
1>  Project Lib.Web (.NETFramework,Version=v4.5.2) will be compiled because inputs were modified
1>  Compiling Lib.Web for .NETFramework,Version=v4.5.2
1>  Compilation succeeded.
1>      0 Warning(s)
1>      0 Error(s)
1>  Time elapsed 00:00:00.5610481
1>
========== Build: 1 succeeded, 0 failed, 3 up-to-date, 0 skipped ==========
```
