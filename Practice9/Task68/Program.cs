// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

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

int m = GetInt("Введите число m: ");
float n = GetInt("Введите число n: ");

float AckermannFunction(int m, float n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return AckermannFunction(m - 1, 1);
    else if ((m > 0) && (n > 0)) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    else return 0;
}

Console.WriteLine($"Функция Аккермана для числе {m} и {n} равна {AckermannFunction(m, n)}");