dotnet dev-certs https -ep aspnetapp.pfx -p seigi@123
dotnet dev-certs https --trust
copy aspnetapp.pfx ..\..\programs\MultiPurposeAuthSiteCore\MultiPurposeAuthSiteCore\aspnetapp.pfx