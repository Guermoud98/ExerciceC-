# ExerciceC-  
TP 4 : Héritage  

Objectifs :  
• Créer une classe dérivée.  
• Ajouter des méthodes à une classe dérivée.  
• Utiliser les membres statiques  
• Redéfinir des méthodes dans une classe dérivée.  

Exercice : Classe Compte  

• Un compte bancaire est caractérisé par le nom de son titulaire et son solde.  
o Le solde peut être positif (compte créditeur) ou négatif (compte débiteur).  
o Chaque compte est caractérisé par un code incrémenté automatiquement.  
o Le code et le nom d'un compte sont accessibles en lecture seulement.  
o A sa création, un compte bancaire a un solde nul et un code incrémenté.  
o Il est aussi possible de créer un compte en précisant son solde initial. 
o Utiliser son compte consiste à pouvoir y faire des dépôts et des retraits. Pour ces
deux opérations, il faut connaître le montant de l'opération.  
o L'utilisateur peut aussi consulter le solde de son compte par la méthode ToString()
et tester l’égalité de deux comptes par la méthode Equals.  

• Un compte Epargne est un compte bancaire qui possède en plus un champ « Taux
Intérêt » et une méthode calculIntérêt() qui permet de mettre à jour le solde en tenant
compte des intérêts.  

• Un ComptePayant est un compte bancaire pour lequel chaque opération de retrait et de
versement est payante et vaut une commission fixe.  

DotNet Travaux pratiques  

Questions :  
1. Définir la classe Compte.  
2. Définir la classe CompteEpargne.  
3. Définir la classe ComptePayant.  
4. Créer un programme permettant de tester ces classes avec les actions suivantes:  
• Créer une instance de la classe Compte , une autre de la classe CompteEpargne et
une instance de la classe ComptePayant.  
• Faire appel à la méthode déposer() de chaque instance pour déposer une somme
quelconque dans ces comptes.  
• Faire appel à la méthode retirer() de chaque instance pour retirer une somme
quelconque de ces comptes.  
• Faire appel à la méthode calculInterêt() du compte Epargne.
• Afficher le solde des 3 comptes.  