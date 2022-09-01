// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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

void IntBetweenMAndN(int m, int n)
{
    if (m < n)
    {
        if (m == n)
        {
            Console.Write(m);
            return;
        }
        Console.Write(m+", ");
        IntBetweenMAndN(m + 1, n);
    }
    else
    {
        if (m == n)
        {
            Console.Write(m + "]");
            return;
        }
        Console.Write(m + ", ");
        IntBetweenMAndN(m - 1, n);
    }
}

int m = GetInt("Введите первое число ряда");
int n = GetInt("Введите последнее число ряда");

Console.Write("Получившийся ряд: [");
IntBetweenMAndN(m, n);
