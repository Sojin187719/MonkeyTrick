# MonkeyTrick
## Choix d'implémentation

###### 1. Observer
Un design pattern Observer a été utilisé pour permettre au spectateur de réagir à n'importe quel tour d'un singe sans devoir systèmatiquement vérifier si celui-ci n'est pas entrain d'en réaliser un. 
De plus, grâce à la classe **Observable** qu'hérite **Monkey**, on lui retire la responsabilité de devoir gérer les spectateurs qui sont entrain de l'observer et on a pas à passer par un couplage faible dans lequel le singe appelerait directement les méthodes d'action de **Spectator**.
###### 2. ITrick
Afin de respecter au mieux les règles SOLID pour avoir un code éfficient, j'ai utilisé une interface *ITRick* qui est implémentée par deux autres classes : **MusicalTrick** et **AcrobaticTrick**. 
De cette façon, en utilisant le polymorphisme, la classe **Monkey** ne doit jamais se soucier de quel type de tour il doit manipuler lors de son spectacle. De plus, cette structure permet de pouvoir ajouter d'autres types de tours sans devoir étendre et modifier la classe **Monkey**.
###### 3. TrickList
La classe **Monkey** va directement contenir un Objet **TrickList** qui représente une liste de *ITrick*. De cette façon, on retire la responsabilité,  à la classe **Monkey**,  de gérer les différentes méthodes CRUD liées à une liste de tours.
###### 4. Exceptions
Des exceptions sont utilisées pour gérer les cas où les listes sont vides ou contiennent déjà l'élèment à ajouter. 



