#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
EXPOSE 80


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./BethanysPieShopHRM.Api/.", "./BethanysPieShopHRM.Api/."]
COPY ["./BethanysPieShopHRM.App/.", "./BethanysPieShopHRM.App/."]
COPY ["./BethanysPieShopHRM.ComponentsLibrary/.", "./BethanysPieShopHRM.ComponentsLibrary/."]
COPY ["./BethanysPieShopHRM.Shared/.", "./BethanysPieShopHRM.Shared/."]

WORKDIR /src/BethanysPieShopHRM.Api

RUN dotnet restore

RUN dotnet publish "BethanysPieShopHRM.Api.csproj" -c Release -o /src/publish /p:UseAppHost=false

FROM base AS final
COPY --from=build /src/publish .

ENTRYPOINT ["dotnet", "BethanysPieShopHRM.Api.dll"]