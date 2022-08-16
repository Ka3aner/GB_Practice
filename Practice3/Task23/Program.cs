// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int GetInt(string message)
{
    Console.Write(message+": ");
    string str = Console.ReadLine();
    int number;
    if (int.TryParse(str, out number)) return number;
    else
    {
        Console.WriteLine("Введено не целое число, повторите ввод");
        return GetInt(message);
    }
    return 0;
}

int N = GetInt("Введите желаемое количество кубов в строке");

for(int i = 0; i < N; i++)
{
    if (i == N-1) Console.Write(Math.Pow(i+1,3));
    else Console.Write(Math.Pow(i+1,3)+", ");
}