
::start mstsc /ADMIN /v:wetest.fun
@echo off
echo cd=%cd%
echo %%~dp0=%~dp0
echo %1; %2; %*
echo %~1; %~2
if "%~1" equ "-a" echo %~1
