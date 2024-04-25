#region Exemple simple
//int number;
//int min;
//do
//{
//    Console.WriteLine("Veuillez indiquer un nombre :");
//} while (!int.TryParse(Console.ReadLine(), out number));
//min = number;
//int count = 1;
//do
//{
//    do
//    {
//        Console.WriteLine("Veuillez indiquer un nombre :");
//    } while (!int.TryParse(Console.ReadLine(), out number));
//    if (number < min)
//    {
//        min = number;
//    }
//    count++;
//} while (count < 10);
//Console.WriteLine($"La plus petite valeur est {min}."); 
#endregion

#region Exemple avec Null

int number;
int? min = null;

int count = 0;
do
{
    do
    {
        Console.WriteLine("Veuillez indiquer un nombre :");
    } while (!int.TryParse(Console.ReadLine(), out number));
    min ??= number;         //min = (min is null) ? number : min;
    min = (number < min) ? number : min;
    count++;
} while (count < 10);
Console.WriteLine($"La plus petite valeur est {min}.");

#endregion