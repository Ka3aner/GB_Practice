// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
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

double IntPow(double A, double B)
{
    return Math.Pow(A, B);
}

double A = GetDouble("Введите число, которое будет возводиться в степень");
double B = GetDouble("Введите число, которое показывает степень");

Console.WriteLine("Число " + A + " в степени " + B + " равно " + IntPow(A, B));