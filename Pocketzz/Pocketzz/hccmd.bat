@echo off

SETLOCAL EnableDelayedExpansion
for /F "tokens=1,2 delims=#" %%a in ('"prompt #$H#$E# & echo on & for %%b in (1) do     rem"') do (
  set "DEL=%%a"
)

cls

call :colorEcho 0a "███████████████████████████████"
call :colorEcho 0a "█─█─█─▄▄▄─█─▄▄▄─█▄─▀█▀─▄█▄─▄▄▀█"
call :colorEcho 0a "█─▄─█─███▀█─███▀██─█▄█─███─██─█"
call :colorEcho 0a "▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▀▀"
echo.
echo.
echo This is just a beta version. its not working yet
call :colorEcho 04 "---------"
call :colorEcho 04 "|"
set /p c="----> "
pause

:colorEcho
echo off
<nul set /p ".=%DEL%" > "%~2"
findstr /v /a:%1 /R "^$" "%~2" nul
del "%~2" > nul 2>&1i