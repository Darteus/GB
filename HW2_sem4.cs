// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DefSum(int num)
{
    int sum = 0;
    int arg = 0;
    while (num > 0)
    {
        arg = num % 10;
        sum = sum + arg;
        num = num / 10; 
    }
    return sum;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

int num = GetInfo("Введите число: ");
Console.WriteLine($"Сумма цифр числа {num} равна {DefSum(num)}");