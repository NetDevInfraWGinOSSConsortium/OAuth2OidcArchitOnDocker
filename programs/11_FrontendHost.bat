rem このファイルは、SJISでないと動かない。
setlocal

@rem --------------------------------------------------
@rem Turn off the echo function.
@rem --------------------------------------------------
@echo off

@rem --------------------------------------------------
@rem Get the path to the executable file.
@rem --------------------------------------------------
set CURRENT_DIR="%~dp0"

@rem --------------------------------------------------
@rem Execution of the common processing.
@rem --------------------------------------------------
call %CURRENT_DIR%z_Common.bat

rem --------------------------------------------------
rem Batch build of ASPNETWebServiceCore.
rem --------------------------------------------------
dotnet restore "Frontend\FrontendHost.sln"
dotnet msbuild %COMMANDLINE% "Frontend\FrontendHost.sln"

pause

rem -------------------------------------------------------
endlocal
