@echo off
cd %~dp0
set out=%1
if defined out (
	 build c && 7z a -t7z -mx9 -x!*.csproj -x!*.csproj.user -x!AssemblyInfo.cs -x!maketpl.bat -x!Resources\cfg.ezcfg -x!Resources\data.7z -xr!bin -xr!obj -xr!Properties "%out%" ".\*"
) else (
	echo 请指定输出路径！(maketpl "输出路径")
)