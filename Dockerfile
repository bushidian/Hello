FROM microsoft/dotnet
WORKDIR /app

COPY *.csproj ./

COPY . ./
RUN dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/hello.dll"]

# CMD [ "dotnet", "out/hello.dll" ]

# PORT

EXPOSE 5004


