# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution and restore dependencies
COPY SimpleAPISln.sln ./
COPY src/SimpleAPI/SimpleAPI.csproj ./src/SimpleAPI/
COPY test/SimpleAPI.Test/SimpleAPI.Test.csproj ./test/SimpleAPI.Test/
RUN dotnet restore

# Copy everything and build
COPY . .
RUN dotnet publish src/SimpleAPI/SimpleAPI.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Expose API default port
EXPOSE 8080
ENTRYPOINT ["dotnet", "SimpleAPI.dll"]
