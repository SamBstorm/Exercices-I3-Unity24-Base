Console.WriteLine("Veuillez entrer votre nombre : ");
int nbr = int.Parse(Console.ReadLine());
if( (nbr/2) + (nbr/2) == nbr)
{
    Console.WriteLine($"Le nombre {nbr} est paire!");
}
else
{
    Console.WriteLine($"Le nombre {nbr} est impair.");
}