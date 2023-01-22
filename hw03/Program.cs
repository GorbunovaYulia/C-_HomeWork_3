/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void Kub(int number)
{
    int numberK = 1;
    while (numberK <= number)
    {
        int result = (int)Math.Pow(numberK,3);
        Console.Write(result + " ");
        numberK++;
    }
}

int number = GetUserValue("Введите число");
Kub(number);