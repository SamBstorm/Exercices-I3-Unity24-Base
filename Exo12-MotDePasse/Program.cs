const string MDP = "Test1234=";
string mdp;
int count = 0;
do
{
    Console.WriteLine("Entrer un mot de passe :");
    mdp = Console.ReadLine().Trim();
    count++;
} while ( (mdp != MDP) && count < 3 );

if (mdp == MDP)
{
    Console.WriteLine("Bienvenue, que puis-je faire pour vous?");
}
else
{
    Console.WriteLine("Ce compte est à présent bloqué.");
}