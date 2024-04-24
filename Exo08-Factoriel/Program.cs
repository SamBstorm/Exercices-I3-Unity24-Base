bool isConverted;
int number;
do
{
    Console.WriteLine("Veuillez indtoduire un nombre entier :");
    string input = Console.ReadLine();
    isConverted = int.TryParse(input, out number);
} while (!isConverted);

long result = 1;
int i = 0;
while (i < number)
{
    checked
    {
        result *= (number - i); //6 * 5 * 4 * 3 * 2 * 1
    }
    i++;
}

Console.WriteLine($"Le factoriel de {number} est {result}");