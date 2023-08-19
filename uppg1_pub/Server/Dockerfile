#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["uppg1_pub/Server/uppg1_pub.Server.csproj", "uppg1_pub/Server/"]
COPY ["uppg1_pub/Client/uppg1_pub.Client.csproj", "uppg1_pub/Client/"]
COPY ["uppg1_pub/Shared/uppg1_pub.Shared.csproj", "uppg1_pub/Shared/"]
RUN dotnet restore "uppg1_pub/Server/uppg1_pub.Server.csproj"
COPY . .
WORKDIR "/src/uppg1_pub/Server"
RUN dotnet build "uppg1_pub.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "uppg1_pub.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "uppg1_pub.Server.dll"]