Console.WriteLine("Veuillez entrer les 12 chiffres qui compose votre BBAN :");
string bban = Console.ReadLine();
if (bban.Length == 12 && long.TryParse(bban, out _))
{
    Console.WriteLine("Ce BBAN est au bon format");
    long tenFirst = long.Parse(bban.Substring(0, 10));
    short twoLast = short.Parse(bban.Substring(10));
    short modulo = (short)(tenFirst % 97);
    string result = (modulo == twoLast || (modulo == 0 && twoLast == 97)) ? "OK" : "KO";
    Console.WriteLine(result);
    if(result == "OK")
    {
        long code = long.Parse($"{twoLast}{twoLast}111400");
        short moduloCode = (short)(98 - (code % 97));
        Console.WriteLine($"BE{((moduloCode < 10)? "0" : "")}{moduloCode}{bban}");
    }
}
else
{
    Console.WriteLine("Le BBAN n'est pas au bon format.");
}