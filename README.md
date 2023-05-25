# SpringChallenge2023

## Installation

Ouvrir le fichier `merge.ps1`
Modifier la variable `$proPath` pour qu'elle corresponde au chemin du dossier du `sln` du projet
Lorsque le projet `App`sera build, le résultat sera copié dans le dossier `Ouputs\output.cs` de la solution

Suivez le [tutoriel de codingame]("https://www.codingame.com/forum/t/codingame-sync-beta/614") pour syncrhoniser le fichier output.cs avec l'éditeur de code de codingame


Il est possible que le script powershell ne doit pas autorisé à être executé sur votre machine.
Pour corriger le soucis voir le lien suivant : 
[Unrestricted](https://www.adminmalin.fr/powershell-autoriser-lexecution-de-scripts/)
[Set-ExecutionPolicy](https://docs.microsoft.com/fr-fr/powershell/module/microsoft.powershell.security/set-executionpolicy?view=powershell-7.1)


## Usage
Dans le projet App, le `program.cs` contient le code de l'IA

Il vous faudra implémenter les méthodes de l'interface `IGameManager`.
Pour lire les données d'entrés vous avez la classe `App.Common.Helpers`.SystemHelpers`

## Important

Les using doivent être déclaré dans le namespace pour éviter des collisions lors de la fusion des fichiers `*.cs`


