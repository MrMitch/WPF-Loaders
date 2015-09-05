@echo off
"%PROGRAMFILES(x86)%\MSBuild\14.0\Bin\MsBuild.exe" %~dp0MrMitch.Loaders\MrMitch.Loaders.csproj /t:Build;Package /p:Configuration="Release 4.5";Configuration="Release 4.6"