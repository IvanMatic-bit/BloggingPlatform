FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5010
ENV ASPNETCORE_URLS=http://+:5010


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .

FROM build AS publish
RUN dotnet publish "BloggingPlatform" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "BloggingPlatform.dll"]