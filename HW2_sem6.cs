// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2; x * (k1 - k2) = b2 - b1; x = b2-b1/(k1-k2)

double DefCoor(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return x;
    return y;
}

int GetInfo(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double b1 = GetInfo("Введите координату х первой прямой");
double k1 = GetInfo("Введите координату у первой прямой");
double b2 = GetInfo("Введите координату х второй прямой");
double k2 = GetInfo("Введите координату у второй прямой");
double x = DefCoor(b1, k1, b2, k2);
double y = DefCoor(b1, k1, b2, k2);

Console.WriteLine("b1 = " + b1 + ", " + "k1 = " + k1 + ", " + "b2 = " + b2 + ", " + "k2 = " + k2 + " - > (" + string.Join("; ", x, y) +")");