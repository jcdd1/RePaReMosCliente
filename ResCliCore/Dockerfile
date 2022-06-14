#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY ["ResCliCore/nuget.config", "ResCliCore/"]
#COPY ["nuget.config", "."]
COPY ./NuGet.Config /nuget.config
COPY ["ResCliCore/ResCliCore.csproj", "ResCliCore/"]
RUN dotnet restore "ResCliCore/ResCliCore.csproj"
COPY . .
WORKDIR "/src/ResCliCore"
RUN dotnet build "ResCliCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ResCliCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ResCliCore.dll"]