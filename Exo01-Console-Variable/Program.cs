Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Bonjour! Veuillez indiquer votre nom : ");
string username = Console.ReadLine();
Console.WriteLine($"Enchanté {username}!\nVeuillez introduire un premier nombre :");
string firstNumber = Console.ReadLine();
Console.WriteLine($"Ok {username}!\nMaintenant, introduisez un second nombre :");
string secondNumber = Console.ReadLine();
Console.WriteLine($"Le premier nombre est : {firstNumber} ; le second est : {secondNumber}.");
Thread.Sleep( 1000 );  
Console.WriteLine("✨Abracadabra!✨");
string temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;
Console.WriteLine($"Maintenant, le premier nombre est : {firstNumber} ; le second est : {secondNumber}.");
