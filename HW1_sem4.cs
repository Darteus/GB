// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DefStep(int arg1, int arg2)
{
    int result = 1;
    for (int i = 1; i <= arg2; i++)
    {
        result = result * arg1;
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}
int num1 = GetInfo("Введите число А: ");
int num2 = GetInfo("Введите число В: ");

Console.WriteLine($"A в степени B равно {DefStep(num1, num2)}");