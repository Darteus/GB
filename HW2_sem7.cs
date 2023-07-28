// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void DefNum(int[,] massiv, int num)
{
    int s = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
                if (massiv[i, j] == num)
                    s = 1;
                if (massiv[i, j] != num)
                    s = 0;
        }
    }
if (s == 1)
    Console.WriteLine(num + " - > есть в массиве");
    else
        Console.WriteLine(num + " -> нет в массиве");
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Rows = ");
int col = GetInfo("Collumns = ");
int num = GetInfo("введите число ");
int[,] massiv = DefMatrix(rows, col, -20, 20);
PrintDoMassiv(massiv);
DefNum(massiv, num);