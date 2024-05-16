Console.OutputEncoding = System.Text.Encoding.Unicode;

int position = 0;
bool[] chemin = new bool[10];

for (int i = 0; i < chemin.Length; i++)
{
    chemin[i] = false;
}
chemin[position] = true;

string entry;

do
{
    Console.Clear();
    foreach (bool cell in chemin)
    {
        Console.Write((cell)?"😃":"-");
    }
    Console.WriteLine();

    Console.WriteLine("Que voulez-vous faire ? (q) Gauche | (d) Droite | (x) Quitter");
    entry = Console.ReadLine();
    chemin[position] = false;
    switch (entry)
    {
        case "q":
            if (position != 0)
            {
                position--;
            }
            break;
        case "d":
            if (position != chemin.Length - 1)
            {
                position++;
            }
            break;
    }
    chemin[position] = true; 
} while (entry != "x");