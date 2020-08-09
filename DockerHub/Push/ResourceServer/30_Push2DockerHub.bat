docker images

pause

set IMAGE_ID_STR=
set /p IMAGE_ID_STR="対象(aspnetwebservicecore:latest)のイメージIDを入力: "
echo 入力したイメージID: %IMAGE_ID_STR%

pause

docker tag %IMAGE_ID_STR% osscjpdevinfra/aspnetwebservicecore:OAuth2OidcArchitOnDocker
docker images

pause

docker login

pause

docker push osscjpdevinfra/aspnetwebservicecore:OAuth2OidcArchitOnDocker

pause
