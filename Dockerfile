FROM microsoft/dotnet:runtime 
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

RUN cd out

ENTRYPOINT ["dotnet", "out/hello.dll"]

EXPOSE 5000

