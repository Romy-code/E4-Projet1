# <p align="center">Allons conquerir l'espace ! (readme en cours)</p>

1. [Présentation](#présentation)
2. [Outils](#Outils)
3. [Exemple](#Exemple)
4. [Diagramme UML](#DiagrammeUML)

## Présentation
***
Jeu : la conquête de l'espace

Dans ce jeu l'utilisateur se situe dans l'espace son but étant d'éviter les projectiles mais aussi d'éliminer les envahisseurs.


## Outils
***
	> C# en complement avec l'interface graphique windowsForms

> **Note:** Le readme est susceptible de changer au fur et à mesure de l'élaboration de l'application web 


## Exemple 



## Diagramme UML
!includeurl https://raw.githubusercontent.com/linux-china/plantuml-gist/master/src/main/uml/plantuml_gist.puml
@startuml
actor "joueur" as joueur
actor "alien" as alien

package Jeu{
usecase "tirer" as tirer
usecase "bouger droite-gauche" as bouger
usecase "avancer" as avancer
}

joueur--> tirer
alien-->tirer
joueur--> bouger
alien-->avancer
@enduml

```
