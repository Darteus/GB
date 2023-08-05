// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Rec(int lastNum, int firstNum)
{
    if (lastNum > firstNum) return $"{lastNum}" + ", " + Rec(lastNum-1, firstNum);
    else return Convert.ToString(firstNum);
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInfo("start number = ");
int n = 1;
Console.WriteLine($"N = {m} - > {Rec(m, n)}");