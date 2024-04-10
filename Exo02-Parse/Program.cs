Console.Write("Veuillez introduire un premier nombre :");
string userInput = Console.ReadLine();
int premierNombre = int.Parse(userInput);

Console.Write("Veuillez introduire un second nombre :");
int secondNombre = int.Parse(Console.ReadLine()) ;

Console.WriteLine($"{premierNombre} + {secondNombre} = {premierNombre + secondNombre}");


//Méthode dégueulasse : Pas clair, pas possible de ré-utiliser les valeurs
//Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));



