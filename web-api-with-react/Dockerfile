FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_14.x | bash - \
    && apt-get install -y \
        nodejs \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /src
COPY ["web-api-with-react/web-api-with-react.csproj", "web-api-with-react/"]
RUN dotnet restore "web-api-with-react/web-api-with-react.csproj"
COPY . .
WORKDIR "/src/web-api-with-react"
RUN dotnet build "web-api-with-react.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "web-api-with-react.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "web-api-with-react.dll"]
