@echo off
set destDir=C:\Users\%username%\Downloads\EZSetup
cd %~dp0
xcopy "*.exe" "%destDir%" /c /i /f /y
xcopy "lib" "%destDir%\lib" /e /c /i /f /y
xcopy "Refer" "%destDir%\Refer" /e /c /i /f /y
xcopy "TemplatePack" "%destDir%\TemplatePack" /e /c /i /f /y
echo �Ѿ��������ļ�������%destDir%�У�