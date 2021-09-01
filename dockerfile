FROM mcr.microsoft.com/dotnet/sdk:5.0
COPY ./castles_and_knights/bin/Release/net5.0/publish/ App/
WORKDIR /App
CMD ASPNETCORE_URLS=http://*:$PORT dotnet castles_and_knights.dll
