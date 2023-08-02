$csprojFile = "$PSScriptRoot/nuget.csproj"
Remove-Item -Recurse -Force output
dotnet restore $csprojFile
dotnet pack $csprojFile -c Debug --no-build -o output --no-restore
Remove-Item -Recurse -Force bin
Remove-Item -Recurse -Force obj