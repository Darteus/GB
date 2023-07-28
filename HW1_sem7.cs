// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] DefMatrix(int m, int n)
{
    double[,] result = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = (double)rand.Next(-100, 100)/10;
        }
    }
    return result;
}

void DefPrintMatrix(double[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
        Console.Write($"{massiv[i, j]} ");
        }
        Console.WriteLine();
    } 
}  

int GetInfo(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = 3;
int n = 4;
double[,] massiv = DefMatrix(m, n);
DefPrintMatrix(massiv);