if exist aspnetapp.pfx (
  echo ファイルが存在しています。
)
else (
  dotnet dev-certs https -ep aspnetapp.pfx -p seigi@123
  dotnet dev-certs https --trust
)

copy aspnetapp.pfx ..\..\programs\MultiPurposeAuthSiteCore\MultiPurposeAuthSiteCore\aspnetapp.pfx
copy aspnetapp.pfx ..\..\programs\ResourceServer\ASPNETWebServiceCore\aspnetapp.pfx
