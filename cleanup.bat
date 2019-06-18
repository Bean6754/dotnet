@echo off
title Cleanup
color e0

REM User-specific files
del *.rsuser /f /s /q
del *.suo /f /s /q
del *.user /f /s /q
del *.userosscache /f /s /q
del *.sln.docstates /f /s /q

REM User-specific files (MonoDevelop/Xamarin Studio)
del *.userprefs /f /s /q

REM Mono auto generated files
del mono_crash.* /f /s /q

REM Visual Studio 2015/2017 cache/options directory
FOR /d /r . %%d IN (".vs") DO @IF EXIST "%%d" rd /s /q "%%d"

REM Visual Studio 2017 auto generated files
FOR /d /r . %%d IN ("Generated Files") DO @IF EXIST "%%d" rd /s /q "%%d"

REM Benchmark Results
FOR /d /r . %%d IN ("BenchmarkDotNet.Artifacts") DO @IF EXIST "%%d" rd /s /q "%%d"

pause
exit