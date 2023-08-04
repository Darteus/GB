// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void GetMatr(int a1, int a2, int a3, int a4, int b1, int b2, int b3, int b4)
{
    int c1 = a1*b1 + a2*b3;
    int c2 = a1*b2 + a2*b4;
    int c3 = a3*b1 + a4*b3;
    int c4 = a3*b2 + a4*b4;
    Console.WriteLine(a1 + " " + a2 + " / " + b1 + " " + b2);
    Console.WriteLine(a3 + " " + a4 + " / " + b3 + " " + b4);
    Console.WriteLine("Результирующая матрица будет:");
    Console.WriteLine(c1 + " " + c2);
    Console.WriteLine(c3 + " " + c4);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a1 = GetInfo("A1 = ");
int a2 = GetInfo("A2 = ");
int a3 = GetInfo("A3 = ");
int a4 = GetInfo("A4 = ");
int b1 = GetInfo("B1 = ");
int b2 = GetInfo("B2 = ");
int b3 = GetInfo("B3 = ");
int b4 = GetInfo("B4 = ");
GetMatr(a1, a2, a3, a4, b1, b2, b3, b4);