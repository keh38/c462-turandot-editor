; -- sync.iss --

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!
#define SemanticVersion() \
   GetVersionComponents("..\Turandot Editor\bin\Release\net8.0-windows\Turandot Editor.exe", Local[0], Local[1], Local[2], Local[3]), \
   Str(Local[0]) + "." + Str(Local[1]) + ((Local[2]>0) ? "." + Str(Local[2]) : "")
    

#define verStr_ StringChange(SemanticVersion(), '.', '-')

[Setup]
AppName=Turandot Editor
AppVerName=Turandot Editor V{#SemanticVersion()}
DefaultDirName={commonpf}\EPL\C462\Turandot Editor\V{#SemanticVersion()}
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
Source: "..\Turandot Editor\bin\Release\net8.0-windows\*.*"; DestDir: "{app}"; Flags: replacesameversion
Source: "..\Turandot Editor\bin\Release\net8.0-windows\Images\*.*"; DestDir: "{app}\Images"; Flags: replacesameversion
Source: "..\Turandot Editor\bin\Release\net8.0-windows\runtimes\win\*.*"; DestDir: "{app}\runtimes\win"; Flags: replacesameversion recursesubdirs
Source: "..\Turandot Editor\bin\Release\net8.0-windows\runtimes\win-arm64\*.*"; DestDir: "{app}\runtimes\win-arm64"; Flags: replacesameversion recursesubdirs
Source: "..\Turandot Editor\bin\Release\net8.0-windows\runtimes\win-x64\*.*"; DestDir: "{app}\runtimes\win-x64"; Flags: replacesameversion recursesubdirs
Source: "..\Turandot Editor\bin\Release\net8.0-windows\runtimes\win-x86\*.*"; DestDir: "{app}\runtimes\win-x86"; Flags: replacesameversion recursesubdirs
Source: "..\CHANGELOG.md"; DestDir: "{app}"; Flags: replacesameversion;

[Icons]
Name: "{commondesktop}\Turandot Editor"; Filename: "{app}\Turandot Editor.exe"; IconFilename: "{app}\Turandot.ico"; IconIndex: 0;

[Registry]
Root: HKLM64; Subkey: "Software\EPL"; Flags: uninsdeletekeyifempty
Root: HKLM64; Subkey: "Software\EPL\C462"; Flags: uninsdeletekey
Root: HKLM64; Subkey: "Software\EPL\C462\Turandot Editor"; ValueType: string; ValueName: "InstallPath"; ValueData: "{app}"

