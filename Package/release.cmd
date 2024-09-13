del "*.nupkg"
"..\..\Oqtane.Framework\oqtane.package\nuget.exe" pack Dunamix.Theme.Portfolio.nuspec 
XCOPY "*.nupkg" "..\..\Oqtane.Framework\Oqtane.Server\wwwroot\Packages\" /Y
