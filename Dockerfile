FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
CMD dotnet restore

# Copy everything else and build
COPY . ./
CMD dotnet publish -c Release -o out


# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet MoviesDbMVC.dll
