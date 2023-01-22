/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int GetFirstNumber(int number)
{
    int firstNumber = number/10000;
    return firstNumber;
}
int GetLastNumber(int number)
{
    int lastNumber = number%10;
    return lastNumber; 
}

int number = GetUserValue("Введите пятизначное число");
int FN = GetFirstNumber(number);
int LN = GetLastNumber(number);

if (FN!=LN) 
{
    Console.WriteLine("Это число не является палиндромом");
    
}
else 
{
    int TrexChislo = (number-10000*FN-LN)/10;
    int SN = TrexChislo/100;
    int FourN = GetLastNumber(TrexChislo);
    if (SN==FourN) 
    {
        Console.WriteLine("Это число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Это число не является палиндромом");
    }
}




