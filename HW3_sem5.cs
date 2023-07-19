// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble() + new Random().Next(100);
        Console.Write($"{ randomArray[i]:F2} ");
    }
}

double DefDif(double[] randomArray, double minB, double maxB, double diff)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] < minB)
            minB = randomArray[i];
        if (randomArray[i] > maxB)
            maxB = randomArray[i];
    }
    diff = maxB - minB;
    return diff;
}

double diff = 0;
double minB = 100;
double maxB = 0;
int i = 0;
    mas(a);

Console.Write( "=> " + DefDif(randomArray, minB, maxB, diff));

   
   
    // void ArrayRandom(double size, double minA, double maxA)
    // {
    //     double[] array = new Random(5);
    //     for (int i = 0; i < size; i++)
    //         array[i] = Random.NextDouble();  //new Random().Next(minA, maxA)
    //     //return array;
    // }

    // double DefDif(double[] array, double minB, double maxB, double diff)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         if (array[i] < minB)
    //             minB = array[i];
    //         if (array[i] > maxB)
    //             maxB = array[i];    
    //     }
    //     diff = maxB - minB;
    //     return diff;
    // }
// double[] array = ArrayRandom(5.0, 0.01, 100);
