FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./Wedrowki/
WORKDIR /app/Wedrowki
RUN dotnet restore

# copy and publish app and libraries
WORKDIR /app
COPY . ./Wedrowki/
WORKDIR /app/Wedrowki
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.0 AS runtime
WORKDIR /app
COPY --from=build /app/Wedrowki/out ./
ENTRYPOINT ["dotnet", "Wedrowki.dll"]