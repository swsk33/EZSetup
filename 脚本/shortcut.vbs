'��ݷ�ʽ�����ű�
Dim ExeFile, LnkFile, RunDir, Args
If WScript.Arguments.Count < 3 Then
	call MsgBox("���������������÷���" & Chr(13) & "  " & "shortcut ԭ�ļ�λ�� ��ݷ�ʽλ�� ����Ŀ¼ [���в���]", 16, "����")
	WScript.Quit
ElseIf WScript.Arguments.Count > 4 Then
	call MsgBox("���������������÷���" & Chr(13) & "  " & "shortcut ԭ�ļ�λ�� ��ݷ�ʽλ�� ����Ŀ¼ [���в���]", 16, "����")
	WScript.Quit
ElseIf WScript.Arguments.Count = 3 Then
	ExeFile = WScript.Arguments.Item(0)
	LnkFile = WScript.Arguments.Item(1)
	RunDir = WScript.Arguments.Item(2)
ElseIf WScript.Arguments.Count = 4 Then
	ExeFile = WScript.Arguments.Item(0)
	LnkFile = WScript.Arguments.Item(1)
	RunDir = WScript.Arguments.Item(2)
	Args = WScript.Arguments.Item(3)
End If
If Right(LnkFile, 4) = ".lnk" Then
Else
	LnkFile = LnkFile + ".lnk"
End If
set WshShell = WScript.CreateObject("WScript.Shell")
set shortcut = WshShell.CreateShortcut(LnkFile)
shortcut.TargetPath =ExeFile
shortcut.WindowStyle ="1"
shortcut.IconLocation = ExeFile
shortcut.WorkingDirectory = RunDir
shortcut.Arguments = Args
shortcut.Save