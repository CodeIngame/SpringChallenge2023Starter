# SpringChallenge2023

## Installation

Ouvrir le fichier `merge.ps1`
Modifier la variable `$proPath` pour qu'elle corresponde au chemin du dossier du `sln` du projet
Lorsque le projet `App`sera build, le r�sultat sera copi� dans le dossier `Ouputs\output.cs` de la solution

Suivez le [tutoriel de codingame]("https://www.codingame.com/forum/t/codingame-sync-beta/614") pour syncrhoniser le fichier output.cs avec l'�diteur de code de codingame


## Usage
Dans le projet App, le `program.cs` contient le code de l'IA

Il vous faudra impl�menter les m�thodes de l'interface `IGameManager`.
Pour lire les donn�es d'entr�s vous avez la classe `App.Common.Helpers`.SystemHelpers`

## Important

Les using doivent �tre d�clar� dans le namespace pour �viter des collisions lors de la fusion des fichiers `*.cs`


