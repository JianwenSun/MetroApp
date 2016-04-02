@echo off
SET MSBUILD=%WINDIR%\microsoft.net\framework\v4.0.30319\MSBuild.exe
REM Build for MetroApp
%MSBUILD% ../MetroApp.sln /property:Configuration=Debug;Platform="Any CPU";ReleaseDate=%1;DevelopmentFolder=$(MSBuildProjectDirectory)\..\..\;NoSA=true;NoCA=true


