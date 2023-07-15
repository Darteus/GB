// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

double DefDis(int coorA1, int coorA2, int coorA3, int coorB1, int coorB2, int coorB3)
{
    double distance = Math.Sqrt(Math.Pow(coorB1 - coorA1, 2) + Math.Pow(coorB2 - coorA2, 2) + Math.Pow(coorB3 - coorA3, 2));
    return distance;
}

int GetInfo(string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}

int coorA1 = GetInfo("Введите координату X точки А: ");
int coorA2 = GetInfo("Введите координату У точки А: ");
int coorA3 = GetInfo("Введите координату Z точки А: ");
int coorB1 = GetInfo("Введите координату X точки В: ");
int coorB2 = GetInfo("Введите координату У точки В: ");
int coorB3 = GetInfo("Введите координату Z точки B: ");
Console.WriteLine($"Расстояние мужду точками равно {DefDis(coorA1, coorA2, coorA3, coorB1, coorB2, coorB3)}");