$NuPacks = Get-Item ./Build/Release/*.nupkg
foreach ($pack in $NuPacks) {
  dotnet nuget push $pack -s https://www.nuget.org/api/v2/package -k $args[0]
}