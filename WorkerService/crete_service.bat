@echo off
cd /d %~dp0

REM Windowsサービスに登録する
sc create WorkerService binPath= "{フルパス}\WorkerService.exe"
sc description WorkerService "説明"

pause
