@echo off
set out=%1
if defined out (
	7z a -t7z -mx9 -x!*.csproj -x!*.csproj.user -x!maketpl.bat -xr!bin -xr!obj -xr!Properties "%out%" ".\*"
)