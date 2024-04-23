Console.WriteLine("Veuillez entrer un nombre entier :");
int nb1;
bool isConverted = int.TryParse(Console.ReadLine(), out nb1);
if (isConverted)
{
    Console.WriteLine("Veuillez entrer un nombre entier :");
    int nb2;
    isConverted = int.TryParse(Console.ReadLine(), out nb2);
    if (isConverted && nb2 != 0)
    {
        int divisionEntiere = nb1 / nb2;
        int modulo = nb1 % nb2;
        double division = (double)nb1 / nb2;

        Console.WriteLine($"Avec les valeurs {nb1} et {nb2}, on obtient:");
        Console.WriteLine($"Division entière : {divisionEntiere}");
        Console.WriteLine($"Modulo : {modulo}");
        Console.WriteLine($"Division : {division}");
    }
    else if (isConverted)
    {
        Console.WriteLine("La division par 0 tend vers l'infini et au-delà!");
    }
    else
    {
        Console.WriteLine("La valeur n'est pas un nombre...");
    }
}
else
{
    Console.WriteLine("La valeur n'est pas un nombre...");
}