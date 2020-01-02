Microsoft Windows [Version 6.1.7601]
Copyright (c) 2009 Microsoft Corporation.  All rights reserved.

C:\Windows\system32>cd c:\documents and settings

c:\Documents and Settings>cd MFFADMIN

c:\Documents and Settings\MFFADMIN>sc delete SAWService
[SC] DeleteService SUCCESS

c:\Documents and Settings\MFFADMIN>sc create SAWService binPath= "C:\GSSPL\SAWServices\Debug\LnTSAW_WindowService.exe" start= auto
[SC] CreateService SUCCESS

c:\Documents and Settings\MFFADMIN>sc delete SAWService
[SC] DeleteService SUCCESS

