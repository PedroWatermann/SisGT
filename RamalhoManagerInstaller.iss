[Setup]
AppName=SisGT - Gerenciamento de Tarefas
; Alterar a versão --
AppVersion=1.0.0.0
;--------------------
AppId=SisGT
DefaultDirName={pf}\SisGT
DefaultGroupName=SisGT
UninstallDisplayIcon={app}\SisGT.exe
OutputDir=C:\Users\pedro\source\repos\PedroWatermann\SisGT
; Alterar a versão --
OutputBaseFilename=SisGT
; -------------------
Compression=lzma
SolidCompression=yes
ShowTasksTreeLines=yes

; Permitir que o instalador feche o app anterior
CreateAppDir=yes

[Files]
Source: "C:\Users\pedro\source\repos\PedroWatermann\SisGT\SisGT\bin\Release\SisGT.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\pedro\source\repos\PedroWatermann\SisGT\SisGT\bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\pedro\source\repos\PedroWatermann\SisGT\SisGT\bin\Release\*.config"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\SisGT"; Filename: "{app}\SisGT.exe"
Name: "{userdesktop}\SisGT"; Filename: "{app}\SisGT.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Criar atalho na área de trabalho"; GroupDescription: "Opções adicionais:"
