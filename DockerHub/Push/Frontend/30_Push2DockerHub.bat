docker images

pause

set IMAGE_ID_STR=
set /p IMAGE_ID_STR="�Ώ�(frontendhost:latest)�̃C���[�WID�����: "
echo ���͂����C���[�WID: %IMAGE_ID_STR%

pause

docker tag %IMAGE_ID_STR% osscjpdevinfra/frontendhost:OAuth2OidcArchitOnDocker
docker images

pause

docker login

pause

docker push osscjpdevinfra/frontendhost:OAuth2OidcArchitOnDocker

pause
