docker images

pause

set IMAGE_ID_STR=
set /p IMAGE_ID_STR="�Ώ�(aspnetwebservicecore:latest)�̃C���[�WID�����: "
echo ���͂����C���[�WID: %IMAGE_ID_STR%

pause

docker tag %IMAGE_ID_STR% osscjpdevinfra/aspnetwebservicecore:OAuth2OidcArchitOnDocker
docker images

pause

docker login

pause

docker push osscjpdevinfra/aspnetwebservicecore:OAuth2OidcArchitOnDocker

pause
