// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        result[i] = new Random().Next(-999,1000);
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

int SumEvenPos(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        result += arr[i];
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
    Console.WriteLine("Сумма элементов на нечётной позиции: " + SumEvenPos(arr));
}
else Console.WriteLine("Количество элементов в массиве должно быть больше нуля");