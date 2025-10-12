FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HiuAgent.Web/HiuAgent.Web.csproj", "HiuAgent.Web/"]
RUN dotnet restore "HiuAgent.Web/HiuAgent.Web.csproj"
COPY . .
WORKDIR "/src/HiuAgent.Web"
RUN dotnet build "./HiuAgent.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./HiuAgent.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HiuAgent.Web.dll"]
