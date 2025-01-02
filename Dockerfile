# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

# Copy toàn bộ solution và các project
COPY . .

# Restore dependencies
RUN dotnet restore "LibraryManager.sln"

# Build project
RUN dotnet build "LibraryManager.sln" -c Release -o /app/build

# Publish project
RUN dotnet publish "LibraryManager.sln" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

# Copy output từ stage build
COPY --from=build /app/publish .

# Expose port 80 cho ứng dụng
EXPOSE 80

# Run application
ENTRYPOINT ["dotnet", "LibraryManager.Application.dll"]
