#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Mc2.Image.Recognition.WebTest/Server/Mc2.Image.Recognition.WebTest.Server.csproj", "Mc2.Image.Recognition.WebTest/Server/"]
COPY ["Mc2.Image.Recognition.WebTest/Shared/Mc2.Image.Recognition.WebTest.Shared.csproj", "Mc2.Image.Recognition.WebTest/Shared/"]
COPY ["Mc2.Image.Recognition.WebTest/Client/Mc2.Image.Recognition.WebTest.Client.csproj", "Mc2.Image.Recognition.WebTest/Client/"]
RUN dotnet restore "Mc2.Image.Recognition.WebTest/Server/Mc2.Image.Recognition.WebTest.Server.csproj"
COPY . .
WORKDIR "/src/Mc2.Image.Recognition.WebTest/Server"
RUN dotnet build "Mc2.Image.Recognition.WebTest.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mc2.Image.Recognition.WebTest.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mc2.Image.Recognition.WebTest.Server.dll"]