Console.OutputEncoding = System.Text.Encoding.Unicode;
uint nbRow;
do
{
    Console.WriteLine("Veuillez indiquer le nombre ligne à afficher : ");
} while (!uint.TryParse(Console.ReadLine(), out nbRow));

string result = "";
for (int i = 0; i < nbRow; i++)
{
    result += "🌟";
    Console.WriteLine(result);
}