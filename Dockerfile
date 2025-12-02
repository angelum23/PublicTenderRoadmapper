FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SistemaConcurso.Api/SistemaConcurso.Api.csproj", "SistemaConcurso.Api/"]
COPY ["SistemaConcurso.Domain/SistemaConcurso.Domain.csproj", "SistemaConcurso.Domain/"]
COPY ["SistemaConcurso.Application/SistemaConcurso.Application.csproj", "SistemaConcurso.Application/"]
COPY ["SistemaConcurso.PgRepository/SistemaConcurso.PgRepository.csproj", "SistemaConcurso.PgRepository/"]
RUN dotnet restore "SistemaConcurso.Api/SistemaConcurso.Api.csproj"
COPY . .
WORKDIR "/src/SistemaConcurso.Api"
RUN dotnet build "./SistemaConcurso.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SistemaConcurso.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SistemaConcurso.Api.dll"]
