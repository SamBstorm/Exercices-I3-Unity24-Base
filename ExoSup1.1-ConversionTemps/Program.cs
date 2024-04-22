// See https://aka.ms/new-console-template for more information
Console.WriteLine("Veuillez m'indiquer un temps en secondes :");

string input = Console.ReadLine();

bool isConverted = int.TryParse(input, out int temps);

if(isConverted)
{
    int minutes = temps / 60;
    int seconds = temps % 60;   // temps - (minutes * 60);
    int hours = minutes / 60;
    minutes = minutes % 60;     // minutes - (hours * 60);
    int days = hours / 24;
    hours = hours % 24;         // hours - (days * 24);
    Console.WriteLine($"{temps} secondes correspondent à : {days} jour(s), {hours} heure(s), {minutes} minute(s) et {seconds} seconde(s).");
}
else
{
    Console.WriteLine($"\"{input}\" n'est pas un nombre entier.");
}
