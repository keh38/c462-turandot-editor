; -- sync.iss --

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!
#define SemanticVersion() \
   GetVersionComponents("..\Turandot Editor\bin\Release\Turandot Editor.exe", Local[0], Local[1], Local[2], Local[3]), \
   Str(Local[0]) + "." + Str(Local[1]) + ((Local[2]>0) ? "." + Str(Local[2]) : "")
    

#define verStr_ StringChange(SemanticVersion(), '.', '-')

[Setup]
AppName=Turandot Editor
AppVerName=Turandot Editor V{#SemanticVersion()}
DefaultDirName={commonpf}\EPL\Diagnostics\Turandot Editor\V{#SemanticVersion()}
OutputDir=Output
DefaultGroupName=EPL
AllowNoIcons=yes
OutputBaseFilename=Turandot_Editor_{#verStr_}
UsePreviousAppDir=no
UsePreviousGroup=no
UsePreviousSetupType=no
DisableProgramGroupPage=yes
PrivilegesRequired=admin

[Dirs]
Name: "{commonappdata}\EPL";

[Files]
Source: "..\Turandot Editor\Images\Turandot.ico"; DestDir: "{app}"; Flags: replacesameversion;
Source: "..\Turandot Editor\bin\Release\*.*"; DestDir: "{app}"; Flags: replacesameversion;
Source: "..\Turandot Editor\bin\Release\Images\*.*"; DestDir: "{app}\Images"; Flags: replacesameversion;

[Icons]
Name: "{code:GetShortcutLocation}\Turandot Editor"; Filename: "{app}\Turandot Editor.exe"; IconFilename: "{app}\Turandot.ico"; IconIndex: 0;

[Registry]
Root: HKLM64; Subkey: "Software\EPL"; Flags: uninsdeletekeyifempty
Root: HKLM64; Subkey: "Software\EPL\Diagnostics"; Flags: uninsdeletekey
Root: HKLM64; Subkey: "Software\EPL\Diagnostics\Turandot Editor"; ValueType: string; ValueName: "InstallPath"; ValueData: "{app}"

[Code]
function GetShortcutLocation(Dummy: String): String;
  var user : String;
begin
  Result := ExpandConstant('{commondesktop}');  
  user := GetUserNameString();

  Log(user);
  if CompareStr(Lowercase(user), 'hancock') = 0 then begin
    Result := ExpandConstant('{userdocs}') + '\Programs';  
  end;
  if CompareStr(Lowercase(user), 'ken') = 0 then begin
    Result := ExpandConstant('{userdocs}') + '\Taskbar\Programs';  
  end;
end;

