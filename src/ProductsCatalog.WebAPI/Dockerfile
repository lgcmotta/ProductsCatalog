FROM mcr.microsoft.com/dotnet/core/aspnet:3.0.0-preview6-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0.100-preview6-buster AS build
WORKDIR /src
COPY ["src/ProductsCatalog.WebAPI/ProductsCatalog.WebAPI.csproj", "src/ProductsCatalog.WebAPI/"]
RUN dotnet restore "src/ProductsCatalog.WebAPI/ProductsCatalog.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/ProductsCatalog.WebAPI"
RUN dotnet build "ProductsCatalog.WebAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProductsCatalog.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProductsCatalog.WebAPI.dll"]
