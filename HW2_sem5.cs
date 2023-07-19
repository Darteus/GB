// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] ArrayRandom(int size, int minA, int maxA)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minA, maxA);
    return array;
}

int DefSum(int[] array, int sum)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

int[] array = ArrayRandom(4, 1, 100);
int sum = 0;
Console.WriteLine("[" + string.Join(",", array) + "]" + "-> " + DefSum(array, sum));