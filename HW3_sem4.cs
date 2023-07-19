// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//OR
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] DefMas(int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число {i+1}");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}


// int num = GetInfo("Введите число ");
int size = GetInfo("Введите размер массива ");
int[] array = new int[size];
DefMas(size);

Console.WriteLine($"Полученный массив - [ {string.Join(", ", array)} ]");