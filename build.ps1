#!/usr/bin/env pwsh
$path = "./output"
If(!(Test-Path $path))
{
      New-Item -ItemType Directory -Force -Path $path
}
Push-Location ./spike-go

    go build -o ../output/spike.so -buildmode=c-shared spike.go

Pop-Location

Copy-Item "./output/spike.so" -Destination "./spike-csharp/Spike.CSharp/Spike.CSharp.Library/"

Push-Location ./spike-csharp/Spike.CSharp/Spike.CSharp.Cli
    dotnet build .
    Push-Location /bin/Debug/netcoreapp3.1
        dotnet Spike.CSharp.Cli.dll
    Pop-Location    
Pop-Location
