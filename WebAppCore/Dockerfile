#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80


ENV ASPNETCORE_URLS=http://+:8000;http://+:80;
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebAppCore/WebAppCore.csproj", "WebAppCore/"]
RUN dotnet restore "WebAppCore/WebAppCore.csproj"
COPY . .
WORKDIR "/src/WebAppCore"
RUN dotnet build "WebAppCore.csproj" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "WebAppCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAppCore.dll"]

#docker build --no-cache -f Dockerfile -t sales-manager ..
#docker run -d -p 8000:80 --name webapp sales-manager

#dotnet out/WebAppCore.dll