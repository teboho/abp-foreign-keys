FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Box.FKs.Web.Host/Box.FKs.Web.Host.csproj", "src/Box.FKs.Web.Host/"]
COPY ["src/Box.FKs.Web.Core/Box.FKs.Web.Core.csproj", "src/Box.FKs.Web.Core/"]
COPY ["src/Box.FKs.Application/Box.FKs.Application.csproj", "src/Box.FKs.Application/"]
COPY ["src/Box.FKs.Core/Box.FKs.Core.csproj", "src/Box.FKs.Core/"]
COPY ["src/Box.FKs.EntityFrameworkCore/Box.FKs.EntityFrameworkCore.csproj", "src/Box.FKs.EntityFrameworkCore/"]
WORKDIR "/src/src/Box.FKs.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Box.FKs.Web.Host", "src/Box.FKs.Web.Host"]
COPY ["src/Box.FKs.Web.Core", "src/Box.FKs.Web.Core"]
COPY ["src/Box.FKs.Application", "src/Box.FKs.Application"]
COPY ["src/Box.FKs.Core", "src/Box.FKs.Core"]
COPY ["src/Box.FKs.EntityFrameworkCore", "src/Box.FKs.EntityFrameworkCore"]
WORKDIR "/src/src/Box.FKs.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Box.FKs.Web.Host.dll"]
