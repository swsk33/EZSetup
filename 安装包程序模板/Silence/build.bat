@echo off
set tp=%1
set out=%2
if defined tp (
	if %tp%==c (
		goto buildConfigModule
	) else (
		if %tp%==i (
			if defined out (
				goto buildInstallPack
			) else (
				goto error
			)
		) else (
			if %tp%==u (
				if defined out (
					goto buildUnInstall
				) else (
					goto error
				)
			) else (
				goto error
			)
		)
	)
) else (
	goto error
)
:error
echo ��������
echo �������÷���
echo build ���� [����·��]
echo ���ͣ�
echo c ��������ģ��
echo i ������װ����
echo u ����ж�س���
echo ����ģ���ǲ���ָ������·������������ʱ��Ҫ��
echo ��������˳�...
pause>nul
exit
:buildConfigModule
cd /d %~dp0
set moduleLibCommand=/lib:"Resources" /r:"ReadAndWriteSharp.dll" /r:"Newtonsoft.Json.dll"
set moduleSrc="ConfigModule\*.cs" "Model\*.cs"
set moduleResCommand=/res:"Resources\icon.ico",InstallPack.Resources.icon.ico
csc %moduleResCommand% %moduleLibCommand% /t:exe /out:ConfigModule.exe /platform:anycpu %moduleSrc%
goto end
:buildInstallPack
cd /d %~dp0
set icon="Resources\icon.ico"
set resCommand=/res:"Resources\icon.ico",InstallPack.Resources.icon.ico /res:"Resources\installing.gif",InstallPack.Resources.installing.gif /res:"Resources\7z.dll",InstallPack.Resources.7z.dll /res:"Resources\7z.exe",InstallPack.Resources.7z.exe /res:"Resources\cfg.ezcfg",InstallPack.Resources.cfg.ezcfg /res:"Resources\shortcut.vbs",InstallPack.Resources.shortcut.vbs /res:"Resources\ReadAndWriteSharp.dll",InstallPack.Resources.ReadAndWriteSharp.dll /res:"Resources\Newtonsoft.Json.dll",InstallPack.Resources.Newtonsoft.Json.dll /res:"Resources\data.7z",InstallPack.Resources.data.7z
set referLibCommand=/lib:"Resources" /r:"ReadAndWriteSharp.dll" /r:"Newtonsoft.Json.dll"
set src="installSrc\*.cs" "installSrc\Util\*.cs" "Model\*.cs"
csc %resCommand% %referLibCommand% /win32icon:%icon% /win32manifest:"app.manifest" /out:%out% /t:winexe /platform:anycpu %src%
goto end
:buildUnInstall
cd /d %~dp0
set unIcon="Resources\icon.ico"
set unResCommand=/res:"Resources\icon.ico",InstallPack.Resources.icon.ico /res:"Resources\cfg.ezcfg",InstallPack.Resources.cfg.ezcfg /res:"Resources\Newtonsoft.Json.dll",InstallPack.Resources.Newtonsoft.Json.dll
set unLibCommand=/lib:"Resources" /r:"Newtonsoft.Json.dll"
set unSrc="UninstallModule\*.cs" "Model\*.cs"
csc %unResCommand% %unLibCommand% /win32icon:%unIcon% /win32manifest:"app.manifest" /out:%out% /t:winexe /platform:anycpu %unSrc%
goto end
:end