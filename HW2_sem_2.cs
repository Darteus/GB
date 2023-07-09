// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()); 
int res = 0;
if (num < 100) 
{
    Console.Write("Третьей цифры нет");
}
else
{
   if (num > 1000)
   {
        while (num > 1000)
        {
        num = num / 10;
        }
   }
}
res = num % 100 % 10;
Console.Write(res);