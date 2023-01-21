/*
Принимает на вход координаты точки (Х и У), и выдает номер четверти x!=0, у!=0
2 1
3 4
*/
int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int getQuarterNumber(int x, int y)
{
    int quarter = 0;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else if (x < 0 && y < 0)
    {
        quarter = 3;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    return quarter;
}

void showQuarter(int x, int y)
{
    if (x != 0 && y != 0)
    {
        int quarter = getQuarterNumber(x, y);
        Console.WriteLine($"Точка [{x},{y}] находится в {quarter} четверти");
    }
    else
    {
        Console.WriteLine($"Точка [{x},{y}] находится на оси координат");
    }
}

int x = GetUserValue("Введите X");
int y = GetUserValue("Введите Y");
showQuarter(int x, int y);


