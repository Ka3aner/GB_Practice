// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetInt(string message)
{
    Console.Write(message+": ");
    string str = Console.ReadLine();
    if (!int.TryParse(str, out int number))
    {
        Console.WriteLine("Введено не целое число, повторите ввод");
        return GetInt(message);
    }
    return number;
}

int SumBetweenMandN(int m, int n)
{
    if (m < n)
    {
        if (m == n) return n;
        return SumBetweenMandN(m + 1, n) + m ;
    }
    else
    {
        if (m == n) return n;
        return SumBetweenMandN(m - 1, n) + m ;
    }
}

int m = GetInt("Введите первое число ряда");
int n = GetInt("Введите последнее число ряда");

Console.WriteLine($"Сумма элементов в промежутке [{m}:{n}] равна {SumBetweenMandN(m, n)}");