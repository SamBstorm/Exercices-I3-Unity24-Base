string[] words = ["esperluette", "barbecue", "cinema", "vacances", "coccyx"];

/*
string[] words = new string[5];
words[0] = "esperluette";
words[1] = "barbecue";
words[2] = "cinema";
words[3] = "vacances";
words[4] = "coccyx";
*/

Random RNG = new Random();

string guessWord = words[RNG.Next(words.Length)];
char[] wordLetters = guessWord.ToCharArray();
char[] hiddenLetters = guessWord.ToCharArray();
List<char> userLetters = new List<char>();
int tries = 5;

for (int i = 0; i < hiddenLetters.Length; i++)
{
    hiddenLetters[i] = '_';
}


do
{
    Console.Clear();
    foreach (char hiddenLetter in hiddenLetters)
    {
        Console.Write(hiddenLetter + " ");
    }
    Console.WriteLine();

    char letter;

    do
    {
        Console.WriteLine("A vous de jouer :");
    } while (!char.TryParse(Console.ReadLine().ToLower().Trim(), out letter) || letter < 'a' || letter > 'z');

    if (!userLetters.Contains(letter))
    {
        userLetters.Add(letter);
        bool found = false;

        for (int i = 0; i < wordLetters.Length; i++)
        {
            if (wordLetters[i] == letter)
            {
                hiddenLetters[i] = letter;
                found = true;
            }
        }

        if (!found)
        {
            tries--;
        }
    }
} while (hiddenLetters.Contains('_') && tries > 0);

Console.Clear();
if(!hiddenLetters.Contains('_'))
{
    Console.WriteLine($"Félicitations! Le mot à deviner était bien : {guessWord} !");
}
else
{
    Console.WriteLine($"Désolé, le mot à deviner était : {guessWord}...");
}