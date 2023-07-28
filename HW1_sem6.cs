// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int DefCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count++;
            }   
        }
        return count;
}

int GetInfo(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInfo("Введите первое число ");
int b = GetInfo("Введите второе число ");
int c = GetInfo("Введите третье число ");
int d = GetInfo("Введите четверое число ");
int e = GetInfo("Введите пятое число ");
int[] array = new int[] { a, b, c, d, e };

Console.WriteLine(string.Join(", ", array) + " -> " + DefCount(array));