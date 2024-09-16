FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BasicCalculator/BasicCalculator.csproj", "BasicCalculator/"]
RUN dotnet restore "BasicCalculator/BasicCalculator.csproj"
COPY . .
WORKDIR "/src/BasicCalculator"
RUN dotnet build "BasicCalculator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BasicCalculator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BasicCalculator.dll"]
