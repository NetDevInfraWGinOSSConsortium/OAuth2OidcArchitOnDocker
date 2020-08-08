xcopy /Y /E "..\..\..\programs\Frontend\Host" "FrontendHost\"
rem copy /Y "FrontendHost.csproj" "Host\FrontendHost.csproj"
rem copy /Y "appsettings.json" "Host\appsettings.json"
del /Q "Host\Dockerfile"