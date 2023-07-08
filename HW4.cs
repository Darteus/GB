// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int first = 2;
if (num > 1)
{
    while (first <= num)
    {
        Console.Write(first + " ");
        first += 2;
    }
}