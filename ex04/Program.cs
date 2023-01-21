/*
Принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N 
5 -> 1, 4, 9, 16, 25
*/

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void KvadratnKoren(int number)
{
    int numberKK = 1;
    while (numberKK <= number)
    {
        int result = numberKK * numberKK;
        Console.Write(result + " ");
        numberKK++;
    }
}


int number = GetUserValue("Введите число");
KvadratnKoren(number);

