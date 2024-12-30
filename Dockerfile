# Sử dụng SDK để phát triển
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev

# Cấu hình thư mục làm việc
WORKDIR /app

# Sao chép file project và restore dependencies
COPY ["LibraryManager.csproj", "."]
RUN dotnet restore "./LibraryManager.csproj"

# Sao chép toàn bộ mã nguồn
COPY . .

# Cấu hình lệnh chạy ứng dụng với hot reload
ENTRYPOINT ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:8080"]
