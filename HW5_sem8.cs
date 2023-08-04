// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] DefMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    result[0, 0] = 1;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            result[i, j+1] = result[i, j] + 1;
        }            
    for (int j = n-1; i < m-1; i++)
    {
        result[i+1, n-1] = result[i, n-1] + 1;
    }

    for (int j = n - 2; j >-1; j--)
    {
        result[m-1, j] = result[m-1, j+1] + 1;
    }
    // for (int j=0;  i <m && i > 0 ; i--)
    // {
    //     result[i-1, j] = result[i, j] + 1;
    // }
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

// int GetInfo(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int rows = GetInfo("Rows and Collumns = ");
// int col = rows;
int[,] massiv = DefMatrix(4, 4);
PrintDoMassiv(massiv);