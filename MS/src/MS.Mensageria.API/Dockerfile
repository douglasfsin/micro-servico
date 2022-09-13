#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MS.Mensageria.API/MS.Mensageria.API.csproj", "src/MS.Mensageria.API/"]
RUN dotnet restore "src/MS.Mensageria.API/MS.Mensageria.API.csproj"
COPY . .
WORKDIR "/src/MS.Mensageria.API"
RUN dotnet build "MS.Mensageria.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MS.Mensageria.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MS.Mensageria.API.dll"]