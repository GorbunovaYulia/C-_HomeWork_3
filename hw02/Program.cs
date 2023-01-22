/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    return distance;
}


int x1 = GetUserValue("Введите координату Х первого числа");
int y1 = GetUserValue("Введите координату У первого числа");
int z1 = GetUserValue("Введите координату Z первого числа");
int x2 = GetUserValue("Введите координату Х второго числа");
int y2 = GetUserValue("Введите координату У второго числа");
int z2 = GetUserValue("Введите координату Z второго числа");
double result = getDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние = {Math.Round(result,2)}");