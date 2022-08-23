// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

float GetFloat(string message)
{
    Console.Write(message+": ");
    string str = Console.ReadLine();
    float number;
    if (float.TryParse(str, out number)) return number;
    else
    {
        Console.WriteLine("Введено не целое число, повторите ввод");
        return GetFloat(message);
    }
}

float[] GetFloatArr(int N)
{
    float[] result = new float[N];
    for (int i = 0; i < N; i++)
    {
        result[i] = GetFloat("Введите элемент массива");
    }
    return result;
}

float MaxMinusMin(float[] arr)
{
    float Max = arr[0];
    float Min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < Min) Min = arr[i];
        if (arr[i] > Max) Max = arr[i];
    }
    return Max-Min;
}

string ArrOutput(float[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        result += arr[i].ToString();
        if (i != arr.Length - 1) result += "; ";
        else result += "]";
    }
    return result;
}

int N = GetInt("Введите количество элементов в массиве");

if (N < 1) Console.WriteLine("В массиве должен быть хотя бы 1 элемент");
else
{
    float [] Arr = GetFloatArr(N);
    Console.WriteLine("Ваш массив: " + ArrOutput(Arr));
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + MaxMinusMin(Arr));
}