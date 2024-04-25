#region Exemple avec boucle dans une boucle
//uint nbRep, nbTiret, nbEspace;
//string result = "";

//do Console.WriteLine("Combien de fois le code doit être répété ?");
//while (!uint.TryParse(Console.ReadLine(), out nbRep));

//do Console.WriteLine("Combien de fois le code doit-il contenir des tirets ?");
//while (!uint.TryParse(Console.ReadLine(), out nbTiret));

//do Console.WriteLine("Combien de fois le code doit-il contenir des espaces blancs ?");
//while (!uint.TryParse(Console.ReadLine(), out nbEspace));

//for (int j = 0; j < nbRep; j++)
//{
//	for (int i = 0; i < nbTiret; i++)
//	{
//		result += "-";
//	}

//	for (int i = 0; i < nbEspace; i++)
//	{
//		result += " ";
//	}
//}

//Console.WriteLine($"[{result}]"); 
#endregion

#region Exemple avec 3 boucles différentes
uint nbRep, nbTiret, nbEspace;
string result = "", code= "";

do Console.WriteLine("Combien de fois le code doit être répété ?");
while (!uint.TryParse(Console.ReadLine(), out nbRep));

do Console.WriteLine("Combien de fois le code doit-il contenir des tirets ?");
while (!uint.TryParse(Console.ReadLine(), out nbTiret));

do Console.WriteLine("Combien de fois le code doit-il contenir des espaces blancs ?");
while (!uint.TryParse(Console.ReadLine(), out nbEspace));

for (int i = 0; i < nbTiret; i++)
{
	code += "-";
}

for (int i = 0; i < nbEspace; i++)
{
	code += " ";
}

for (int i = 0; i < nbRep; i++)
{
	result += code;
}

Console.WriteLine($"[{result}]");
#endregion