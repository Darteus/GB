// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да)

void DefPal(int num)
{
    int first = num / 10000;
    int second = num / 1000 % 10;
    int fourth = num % 100 / 10;
    int fifth = num % 10;
    if (first == fifth && second == fourth)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else
    {
        Console.WriteLine($"{num} ->no");
    }
}
int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}
int num = GetInfo("Введите число: ");
DefPal(num);
