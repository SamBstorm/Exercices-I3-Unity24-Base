Console.WriteLine("Veuillez entrer les 12 chiffres qui compose votre BBAN :");
string bban = Console.ReadLine();
if(bban.Length == 12 && long.TryParse(bban, out _))
{
    Console.WriteLine("Ce BBAN est au bon format");
    long tenFirst = long.Parse(bban.Substring(0, 10));
    short twoLast = short.Parse(bban.Substring(10));
    short modulo = (short)(tenFirst % 97);
    string result = (modulo == twoLast || (modulo == 0 && twoLast == 97))? "OK" : "KO" ;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Le BBAN n'est pas au bon format.");
}