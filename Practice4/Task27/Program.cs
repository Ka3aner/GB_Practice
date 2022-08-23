// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
double GetDouble(string message)
{
    Console.Write(message+": ");
    string str = Console.ReadLine();
    double number;
    if (double.TryParse(str, out number)) return number;
    else
    {
        Console.WriteLine("Введено не число, повторите ввод");
        return GetDouble(message);
    }
    return 0;
}

int SumOfDigits(double X)

{
    string str = X.ToString();
    int result = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (int.TryParse(str[i].ToString(), out int n)) result += n;
    }
    return result;
}

double X = GetDouble("Введите число");

Console.WriteLine("Сумма цифр в числе " + X + " равна " + SumOfDigits(X));