# .Net Core example

---

- Build
```
$ docker run --rm \
    -v $PWD:/app \
    -w /app mcr.microsoft.com/dotnet/sdk:6.0 dotnet build
```

- Publish

```
docker run --rm \
    -v $PWD:/app \
    -w /app mcr.microsoft.com/dotnet/sdk:6.0 dotnet publish
```

- Docker build

```
$ docker build -t xxx .
```

- Run 
```
$ docker run -dp port:80 --name yyy xxx
```