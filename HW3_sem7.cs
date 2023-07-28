// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] DefMatrix(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return result;
}
void PrintDoMassiv(int[,] massiv)
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

void DefMid(int[,] massiv, int m, int n)
{
    double mid1 = 0;
    double sum1 = 0;
    double mid2 = 0;
    double sum2 = 0;
    double mid3 = 0;
    double sum3 = 0;
    double mid4 = 0;
    double sum4 = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sum1 = sum1 + massiv[i, 0];
        sum2 = sum2 + massiv[i, 1];
        sum3 = sum3 + massiv[i, 2];
        sum4 = sum4 + massiv[i, 3];
    }
    mid1 = sum1 / m;
    mid2 = sum2 / m;
    mid3 = sum3 / m;
    mid4 = sum4 / m;
    Console.Write(mid1 + ", " + mid2  + ", " + mid3 + ", " + mid4);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = 3;
int col = 4;
int[,] massiv = DefMatrix(rows, col, 0, 10);
PrintDoMassiv(massiv);
DefMid(massiv, rows, col);