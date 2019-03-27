FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MoviesDbMVC/MoviesDbMVC.csproj", "MoviesDbMVC/"]
RUN dotnet restore "MoviesDbMVC/MoviesDbMVC.csproj"
COPY . .
WORKDIR "/src/MoviesDbMVC"
RUN dotnet build "MoviesDbMVC.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MoviesDbMVC.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
CMD dotnet MoviesDbMVC.dll