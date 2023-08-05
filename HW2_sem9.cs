// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Rec(int firstNum, int lastNum)
{
    Console.Write($"M = {firstNum}; N = {lastNum} - > " + Sum(firstNum-1, lastNum));
}
int Sum(int firstNum, int lastNum)
{
    int sum = firstNum;
    if (firstNum == lastNum) return 0;
    else 
        firstNum++;
        sum = firstNum + Sum(firstNum, lastNum);
        return sum;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInfo("start number = ");
int n = GetInfo("end number = ");
Rec(m, n);
