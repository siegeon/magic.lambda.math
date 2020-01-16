
set version=%1
set key=%2

cd %~dp0

dotnet build magic.lambda.math/magic.lambda.math.csproj --configuration Release --source https://api.nuget.org/v3/index.json
dotnet nuget push magic.lambda.math/bin/Release/magic.lambda.math.%version%.nupkg -k %key% -s https://api.nuget.org/v3/index.json
