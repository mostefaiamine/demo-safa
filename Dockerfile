#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DemoSafa/DemoSafa.csproj", "DemoSafa/"]
COPY ["DemoSafa.Design/DemoSafa.Design.csproj", "DemoSafa.Design/"]
COPY ["DemoSafa.Impl/DemoSafa.Impl.csproj", "DemoSafa.Impl/"]
RUN dotnet restore "DemoSafa/DemoSafa.csproj"
COPY . .
WORKDIR "/src/DemoSafa"
RUN dotnet build "DemoSafa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoSafa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoSafa.dll"]