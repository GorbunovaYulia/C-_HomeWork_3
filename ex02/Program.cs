/*
по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у)
*/

int GetUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string getRageFromQuarter(int quarter)
{
    string result = $"Диапазон значений в {quarter} четверти ";
    switch(quarter)
    {
        case 1:
        {
            result += "x > 0, y > 0";// result = result + "x > 0, y > 0"
            break;
        }
         case 2:
        {
            result += "x < 0, y > 0";
            break;
        }
         case 3:
        {
            result += "x < 0, y < 0";
            break;
        }
         case 4:
        {
            result += "x > 0, y < 0";
            break;
        }
        default:
        {
            result = $"Четверти {quarter} не существует";
            break;
        }
    }
    return result;
}

int quarter = GetUserValue("Введите номер четверти");
string rangeDescription = getRageFromQuarter(quarter);
Console.WriteLine(rangeDescription);
