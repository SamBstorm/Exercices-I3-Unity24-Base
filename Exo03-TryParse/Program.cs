Console.Write("Veuillez introduire un premier nombre :");
string userInput = Console.ReadLine();
int premierNombre;
bool isOk = int.TryParse(userInput, out premierNombre);

Console.Write("Veuillez introduire un second nombre :");
int.TryParse(Console.ReadLine(), out int secondNombre);

Console.WriteLine($"{premierNombre} + {secondNombre} = {premierNombre + secondNombre}");