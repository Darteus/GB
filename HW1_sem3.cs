// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System.Linq;
string num = Console.ReadLine();
int [] num_n = num.Select(num => int.Parse(num.ToString())).ToArray();
int [] arrT = new int[num_n.Length];
int count = num_n.Length;
int i = 0;
    while (i < count)
    { 
        arrT[i] = int.Parse(arrT[i]+ "");
        i++; 
    }

void Palin(string num_n)
{
    for (int i = 0; i < 2; i++)
    {
        if (arrT[i] == arrT[count - 1]) i++; count--;
        {
            if (arrT[i] == arrT[count - 1])
            {
                Console.WriteLine(num_n + " -> да");
                Console.WriteLine(arrT[i] + "");
            }
            else
        {
            Console.WriteLine("нет");
        }
        }
    }
    
}

Palin(num); 