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

@rem --------------------------------------------------
@rem Grep & Replace
@rem --------------------------------------------------
set PATH=C:\Program Files (x86)\sakura;%PATH%
sakura -GREPMODE -GKEY="..\..\OpenTouryoAssemblies" -GREPR="..\OpenTouryoAssemblies" -GFOLDER=".\WSIFType_sample" -GFILE="*.csproj" -GOPT=PU
sakura -GREPMODE -GKEY="..\..\OpenTouryoAssemblies" -GREPR="..\OpenTouryoAssemblies" -GFOLDER=".\WSServer_sample" -GFILE="*.csproj" -GOPT=PU

pause

rem --------------------------------------------------
rem Batch build of ASPNETWebServiceCore.
rem --------------------------------------------------
dotnet restore "ResourceServer\ASPNETWebServiceCore.sln"
dotnet msbuild %COMMANDLINE% "ResourceServer\ASPNETWebServiceCore.sln"

pause

rem -------------------------------------------------------
endlocal
