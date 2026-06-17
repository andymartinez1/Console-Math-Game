# BUILD
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY MathGame.sln ./
COPY src/MathGame/MathGame.csproj ./src/MathGame/

RUN dotnet restore ./src/MathGame/MathGame.csproj

COPY src/MathGame/ ./src/MathGame/

RUN dotnet publish ./src/MathGame/MathGame.csproj \
    -c Release \
    -o /app/publish 

# RUN 
FROM mcr.microsoft.com/dotnet/runtime:10.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "MathGame.dll"]