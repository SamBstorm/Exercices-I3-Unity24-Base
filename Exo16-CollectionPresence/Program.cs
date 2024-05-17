Dictionary<string, bool> students = new Dictionary<string, bool>();
string choix;

do
{
    Console.Clear();
    foreach (KeyValuePair<string, bool> student in students)
    {
        Console.WriteLine($"{student.Key}\t:\t{((student.Value)?"Présent(e)":"Absent(e)")}");
    }

    Console.WriteLine("Veuillez choisir :");
    Console.WriteLine("(A)jouter | (S)topper");
    choix = Console.ReadLine().ToLower();
    if (choix == "a")
    {
        Console.WriteLine("Veuillez indiquer le nom de l'élève :");
        string nom = Console.ReadLine();
        if (students.ContainsKey(nom))
        {
            Console.WriteLine("Ce nom est déjà enregistré...");
        }
        else
        {
            students.Add(nom, false);
            Console.WriteLine("Etudiant bien ajouté!");
        }
        Console.ReadLine();
    } 
} while (choix != "s");

do
{
    Console.Clear();
    foreach (KeyValuePair<string, bool> student in students)
    {
        Console.WriteLine($"{student.Key}\t:\t{((student.Value) ? "Présent(e)" : "Absent(e)")}");
    }
    Console.WriteLine("Faîtes un choix :");
    Console.WriteLine("(C)hanger status | (S)topper");
    choix = Console.ReadLine().ToLower();
    if(choix == "c")
    {
        Console.WriteLine("Veuillez indiquer le nom d'un élève présent :");
        string nom = Console.ReadLine();
        if (students.ContainsKey(nom))
        {
            students[nom] = !students[nom];
        }
        else
        {
            Console.WriteLine("Aucun élève enregistré ne porte ce nom...");
        }
        Console.ReadLine();
    }
} while (choix != "s");