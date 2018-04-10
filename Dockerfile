FROM microsoft/dotnet:2.0-sdk AS build-env
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# build runtime image
FROM microsoft/dotnet:2.0-runtime 
WORKDIR /app
COPY --from=build-env /app/out ./

EXPOSE 5000
ENV ASPNETCORE_URLS http://0.0.0.0:5000

ENTRYPOINT ["dotnet", "my-recipe-book.dll"]