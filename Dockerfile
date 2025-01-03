# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution và các file project vào
COPY LibraryManager.sln ./
COPY LibraryManager/ ./LibraryManager/
COPY LibraryManager.Application/ ./LibraryManager.Application/
COPY LibraryManager.Infrastructure/ ./LibraryManager.Infrastructure/

# Restore các dependencies
RUN dotnet restore

# Build project
RUN dotnet publish ./LibraryManager/LibraryManager.csproj -c Release -o /out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out ./

# Expose cổng của ứng dụng
EXPOSE 8080

# Start ứng dụng
ENTRYPOINT ["dotnet", "LibraryManager.dll"]
