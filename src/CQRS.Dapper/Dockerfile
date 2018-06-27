FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 3000

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY src/CQRS.Dapper CQRS.Dapper
WORKDIR /src/CQRS.Dapper
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CQRS.Dapper.dll"]
