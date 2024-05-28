const int TAILLE = 5;

Point?[,] tableau = new Point?[TAILLE,TAILLE];

for (int i = 0; i < TAILLE; i++)
{
    Point p = new Point();
    p.x = p.y = i + 1;
    tableau[i, i] = p;
}

for (int ligne = 0; ligne < TAILLE; ligne++)
{
    for (int colone = 0; colone < TAILLE; colone++)
    {
        Point? cellule = tableau[ligne, colone];
        if (cellule is null)
        {
            Console.Write("\t");
        }
        else
        {
            Console.Write($"X:{((Point)cellule).x} - Y:{cellule?.y}");
        }
    }
    Console.WriteLine();
}


public struct Point
{
    public int x;
    public int y;
}