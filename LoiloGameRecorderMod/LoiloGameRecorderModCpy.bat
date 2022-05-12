; LoiloGameRecorderMod用のシンボリックリンクを作成する
; シンボリックリンクは削除しても元のプログラムには影響を与えない。

if exist LoiLo.Recording.dll GOTO DEL_SIMBOL_MODE



:MAKE_SIMBOL_MODE
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\log4net.dll" log4net.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Recording.Clients.dll" LoiLo.Recording.Clients.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Recording.Core.dll" LoiLo.Recording.Core.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Recording.dll" LoiLo.Recording.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Recording.Facades.dll" LoiLo.Recording.Facades.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Utils.Desktop.dll" LoiLo.Utils.Desktop.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Utils.Interop.dll" LoiLo.Utils.Interop.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Utils.SmartScopes.dll" LoiLo.Utils.SmartScopes.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLo.Utils.Threading.dll" LoiLo.Utils.Threading.dll
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLoRecordingService.exe" LoiLoRecordingService.exe
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLoRecordingService.exe.config" LoiLoRecordingService.exe.config
copy "C:\Program Files\LoiLo\LoiLoGameRecorder\LoiLoRecordingService.xml" LoiLoRecordingService.xml

xcopy /I "C:\Program Files\LoiLo\LoiLoGameRecorder\x64" x64
xcopy /I "C:\Program Files\LoiLo\LoiLoGameRecorder\x86" x86

GOTO :END



:DEL_SIMBOL_MODE

del log4net.dll
del LoiLo.Recording.Clients.dll
del LoiLo.Recording.Core.dll
del LoiLo.Recording.dll
del LoiLo.Recording.Facades.dll
del LoiLo.Utils.Desktop.dll
del LoiLo.Utils.Interop.dll
del LoiLo.Utils.SmartScopes.dll
del LoiLo.Utils.Threading.dll
del LoiLoRecordingService.exe
del LoiLoRecordingService.exe.config
del LoiLoRecordingService.xml

rmdir /s /q x64
rmdir /s /q x86

GOTO :END




:END