Console.OutputEncoding = System.Text.Encoding.Unicode;

List<Livre> books = new List<Livre>([
    new Livre() { auteur = "Stephen King", titre = "Shining", nbPages = 255, prix = 27.99M },
    new Livre() { auteur = "William Shakespeare", titre = "Macbeth", nbPages = 200, prix = 25},
    new Livre() { auteur = "Disney Company", titre = "Le monde de Némo", nbPages = 25, prix = 6.70M },
    new Livre() { auteur = "Jules Vernes", titre = "20.000 lieux sous les mers", nbPages = 384, prix = 5.50M },
    new Livre() { auteur = "Bred Eston Ellis", titre = "American psycho", nbPages = 416, prix = 9.99M}
    ]);
decimal total = 0;
int bookId;

do
{
    Console.Clear();
    Console.WriteLine($"[Identifiant]\t[Auteur]\t[Titre]\t[Nombre de pages]\t[Prix TTC]");
    for (int i = 0; i < books.Count; i++)
    {
        Console.WriteLine($"{i}\t{books[i].auteur}\t{books[i].titre}\t{books[i].nbPages}\t{books[i].prix} €");
    }
    Console.WriteLine($"{books.Count}\tFERMER PROGRAMME");
    Console.WriteLine($"Votre panier compte au total : {total} €");

    do
    {
        Console.WriteLine("Quel livre voulez-vous ajouter dans votre panier ?");

    } while (!int.TryParse(Console.ReadLine(), out bookId) || bookId < 0 || bookId > books.Count);

    if(bookId != books.Count)
    {
        total += books[bookId].prix; 
    }
} while (bookId != books.Count);

public struct Livre
{
    public string auteur, titre;
    public ushort nbPages;
    public decimal prix;
}
