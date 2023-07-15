// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void DefCub(int num)
// {
//     Console.Write($"{num} -> ");
//     for (int i = 1; i < num; i++)
//     {
//         Console.Write(i * i * i + ", "); 
//     }
//     Console.WriteLine(num * num * num + ".");
// }

// int GetInfo(string message)
// {
//     Console.Write(message);
//     int inputNumber = Convert.ToInt32(Console.ReadLine());
//     return inputNumber;
// }

// int num = GetInfo("Введите число: ");
// DefCub(num); 

void DefCub(int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i < num; i++)
    {
        Console.Write(i * i * i + ", ");
    }
    Console.Write(num * num * num + ".");
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}
int num = GetInfo("Введите число: ");
DefCub(num);