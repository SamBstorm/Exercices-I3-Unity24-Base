Console.WriteLine("Veuillez indiquer une année :");
string input = Console.ReadLine();

if(int.TryParse(input, out int annee))
{
    {
        //if(annee %4 == 0)
        //{
        //    if(annee %100 != 0) {
        //        Console.WriteLine($"L'année {annee} est bissextile.");
        //    }
        //    else
        //    {
        //        if(annee %400 == 0) {
        //            Console.WriteLine($"L'année {annee} est bissextile.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"L'année {annee} n'est pas bissextile.");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine($"L'année {annee} n'est pas bissextile.");
        //}
    }

    if ((annee % 400 == 0) || ((annee % 4 == 0) && (annee % 100 != 0)))
    {
        Console.WriteLine($"L'année {annee} est bissextile.");
    }
    else
    {
        Console.WriteLine($"L'année {annee} n'est pas bissextile.");
    }
}
else
{
    Console.WriteLine($"La valeur \"{input}\" n'est pas une année valide.");
}
