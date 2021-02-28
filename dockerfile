FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build

WORKDIR /src

COPY /src/app .

RUN dotnet restore "app.csproj"

RUN dotnet publish "app.csproj" -c Relase 

CMD ["bash"]

 