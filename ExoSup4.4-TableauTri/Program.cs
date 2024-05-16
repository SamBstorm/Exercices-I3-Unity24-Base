int[] tableau = new int[10];

Random RNG = new Random();

for (int i = 0; i < tableau.Length; i++)
{
    tableau[i] = RNG.Next(0,101);
}

foreach (int cell in tableau)
{
    Console.Write($"[{cell}]");
}
Console.WriteLine();

bool estTrie = false;

for (int j = 0; j <= tableau.Length - 2 && !estTrie; j++)
{
    estTrie = true;
    for (int i = 0; i <= tableau.Length - 2 - j; i++)
    {
        if (tableau[i] > tableau[i + 1])
        {
            int temp = tableau[i];
            tableau[i] = tableau[i + 1];
            tableau[i + 1] = temp;
            estTrie = false;
        }
    } 

    foreach (int cell in tableau)
    {
        Console.Write($"[{cell}]");
    }
    Console.WriteLine();
}