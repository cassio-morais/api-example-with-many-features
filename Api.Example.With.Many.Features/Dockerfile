#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Api.Example.With.Many.Features/Api.Example.With.Many.Features.csproj", "Api.Example.With.Many.Features/"]
RUN dotnet restore "Api.Example.With.Many.Features/Api.Example.With.Many.Features.csproj"
COPY . .
WORKDIR "/src/Api.Example.With.Many.Features"
RUN dotnet build "Api.Example.With.Many.Features.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Example.With.Many.Features.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Example.With.Many.Features.dll"]