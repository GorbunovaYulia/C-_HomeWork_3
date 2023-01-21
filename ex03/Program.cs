/*
Принимает на вход координаты двух точек и находит расстояние между ними
А (3,6), В(2,1) = 5,09
*/
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double getDistance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    return distance;
}


int x1 = GetUserValue("Введите координату Х первго числа");
int y1 = GetUserValue("Введите координату У первго числа");
int x2 = GetUserValue("Введите координату Х второго числа");
int y2 = GetUserValue("Введите координату У второго числа");
double result = getDistance(x1, y1,x2, y2);
Console.WriteLine($"Расстояние = {Math.Round(result,2)}");
