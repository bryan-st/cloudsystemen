FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

ARG APP_PORT=443
ARG CERT_PATH=certs/aspnetapp.pfx
ARG CERT_PASSWORD

EXPOSE $APP_PORT

COPY $CERT_PATH /https/aspnetapp.pfx

ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/certs/aspnetapp.pfx
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=$CERT_PASSWORD

ARG APP_UID=1001
RUN useradd -u $APP_UID appuser
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

ARG BUILD_CONFIGURATION=Release

COPY ["FashionClub.API/FashionClub.API.csproj", "FashionClub.API/"]
COPY ["FashionClub.Core.Application/FashionClub.Core.Application.csproj", "FashionClub.Core.Application/"]
COPY ["FashionClub.Domain/FashionClub.Domain.csproj", "FashionClub.Domain/"]
COPY ["FashionClub.Infrastructure.Data/FashionClub.Infrastructure.Data.csproj", "FashionClub.Infrastructure.Data/"]
RUN dotnet restore "FashionClub.API/FashionClub.API.csproj"

COPY . .
WORKDIR "/src/FashionClub.API"
RUN dotnet build "FashionClub.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
RUN dotnet publish "FashionClub.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "FashionClub.API.dll"]
