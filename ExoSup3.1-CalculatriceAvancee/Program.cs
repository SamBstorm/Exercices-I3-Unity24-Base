string operateur = null;
double result = 0;
do
{
    double nb;
    do
    {
        Console.WriteLine("Veuillez indiquer un nombre :");
    } while (!double.TryParse(Console.ReadLine(), out nb));

    if(operateur is null)
    {
        result = nb;
    }
    else
    {
        switch (operateur)
        {
            case "+":
                result += nb;
                break;
            case "-":
                result -= nb;
                break;
            case "*":
                result *= nb;
                break;
            case "/":
                result /= nb;
                break;
        }
    }

    do
    {
        Console.WriteLine("Veuillez introduire un opérateur (+ - / * =) :");
        operateur = Console.ReadLine();
    } while (
        operateur.Length != 1 ||
        !(
            operateur == "+" ||
            operateur == "-" ||
            operateur == "/" || 
            operateur == "*" || 
            operateur == "="
        ));

} while (operateur != "=");

Console.WriteLine(result);