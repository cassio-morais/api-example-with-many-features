#Build Stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ./src .
RUN dotnet restore
RUN dotnet publish -c Release --property:PublishDir=/artifacts /p:UseAppHost=false --no-restore

#Run Stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /artifacts .

ENTRYPOINT ["dotnet", "Api.Example.With.Many.Features.Rest.dll"]