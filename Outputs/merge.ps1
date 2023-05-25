Write-Host 'start merging'


# Mettre le nom du SLN
$solutionName = "SpringChallenge2023Starter"

# Mettre l'emplemacement de votre projet
$proPath = "C:\Projets\Perso\CodinGame"
$personnalPath = "E:\Projets\Visual Studio 2022"

#$pathToUse = $personnalPath
$pathToUse = $proPath


$fromPath = "$pathToUse\$solutionName\App\*.cs"
$toFile = "$pathToUse\$solutionName\Outputs\output.cs"

Write-Host "from -> $fromPath"
Write-Host "to <- $toFile"


Get-ChildItem -Recurse $fromPath | Where {
	$_.Name -like "*.cs" -and $_.Name -notlike "*.Assembly*.cs" -and  $_.Name -notlike "*.GlobalUsings.g.cs"
} | ForEach-Object { Get-Content $_ } | Out-File $toFile


Write-Host 'done merging'
