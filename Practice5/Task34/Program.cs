// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
}

int[] GetRandomArray(int N)
{
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        result[i] = new Random().Next(100,1000);
    }
    return result;
}

int GetEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}

string ArrOutput(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i].ToString();
        if (i != arr.Length - 1) result += ", ";
        else result += "]";
    }
    return result;
}

int N = GetInt("Введите желаемое количество элементов в массиве."+ "\n" + 
"Введите '0', чтобы количество было случайным (не более 20 элементов)");

if (N == 0) N = new Random().Next(1,21);
if (N >= 0)
{
    int[] arr = GetRandomArray(N);
    Console.WriteLine("Массив случайных чисел: " + ArrOutput(arr));
    Console.WriteLine("Количество чётных элементов: " + GetEven(arr));
}
else Console.WriteLine("Количество элементов в массиве должно быть больше нуля");
