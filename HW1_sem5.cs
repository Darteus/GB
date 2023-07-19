// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] ArrayRandom(int size, int begValue, int endValue)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
        Array[i] = new Random().Next(begValue, endValue);
    return Array;
}

int DefCount(int[] array, int count)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count = count + 1;
    } 
    return count;

}

int[] array = ArrayRandom(4, 100, 1000);
int count = 0;

Console.WriteLine("[" + string.Join(", ", array) + "]" + "-> " + DefCount(array, count));