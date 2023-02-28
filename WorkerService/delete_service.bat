@echo off
cd /d %~dp0

REM Windowsサービスから削除する
sc delete WorkerService

pause
