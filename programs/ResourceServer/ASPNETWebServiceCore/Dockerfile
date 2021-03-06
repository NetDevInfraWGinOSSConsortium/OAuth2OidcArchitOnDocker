#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["ASPNETWebServiceCore/ASPNETWebServiceCore.csproj", "ASPNETWebServiceCore/"]
COPY ["../WSServer_sample/WSServer_sample.csproj", "../WSServer_sample/"]
COPY ["../WSIFType_sample/WSIFType_sample.csproj", "../WSIFType_sample/"]
RUN dotnet restore "ASPNETWebServiceCore/ASPNETWebServiceCore.csproj"
COPY . .
WORKDIR "/src/ASPNETWebServiceCore"
RUN dotnet build "ASPNETWebServiceCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASPNETWebServiceCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASPNETWebServiceCore.dll"]