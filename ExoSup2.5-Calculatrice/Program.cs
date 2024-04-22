Console.WriteLine("Votre premier nombre :");
double nb1 = double.Parse(Console.ReadLine());

Console.WriteLine("Quelle opération effectuer ? (+ - / *)");
string ope = Console.ReadLine();

Console.WriteLine("Votre second nombre :");
double nb2 = double.Parse(Console.ReadLine());

#region Version avec le IF
//if (ope == "+")
//    Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 + nb2}");
//else if (ope == "-")
//    Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 - nb2}");
//else if (ope == "*")
//    Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 * nb2}");
//else if (ope == "/")
//{
//    if (nb2 == 0)
//        Console.WriteLine("Erreur : la division par 0 tend vers l'infini et au-delà!");
//    else
//        Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 / nb2}");
//}
#endregion

#region Version avec le SWITCH
switch (ope)
{
	case "+":
        Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 + nb2}");
        break;
    case "-":
        Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 - nb2}");
        break;
    case "*":
        Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 * nb2}");
        break;
    case "/":
        if (nb2 == 0)
        {
            Console.WriteLine("Erreur : la division par 0 tend vers l'infini et au-delà!");
        }
        else
        {
            Console.WriteLine($"{nb1} {ope} {nb2} = {nb1 / nb2}");
        }
        break;
}
#endregion