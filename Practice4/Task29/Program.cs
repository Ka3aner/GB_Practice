// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

void GetArrFromList()
{
    Console.WriteLine("Введите массив через запятую в формате: x1, x2, x3, ... , xn");
    string input = Console.ReadLine();
    string[] arr = input.Replace(" ", "").Split(",");
    Console.Write("Введённый вами массив: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i != arr.Length - 1) Console.Write(", ");
        else Console.Write("]");
    }
}

void GetArrPerElem()
{
    int N = GetInt("Введите количество элементов в массиве: ");
    if (N == 0) 
    {
        Console.WriteLine("В массиве 0 элементов"); 
        return;
    }
    else if (N < 0) 
    {
        Console.WriteLine("Количество элементов должно быть положительным");
        return;
    }
    string[] result = new string[N];
    for (int i = 0; i < N; i++)
    {
        Console.Write("Введите " + i+1 + " элемент массива: ");
        result[i] = Console.ReadLine();
    }
    Console.Write("Введённый вами массив: ");
    Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
        if (i != result.Length - 1) Console.Write(", ");
        else Console.Write("]");
    }

    
}

Console.WriteLine("Введите '1', если хотите ввести массив через запятую");
Console.WriteLine("Введите '2', если хотите ввести массив через Enter");
Console.WriteLine();

string choice = Console.ReadLine();

if (choice == "1") GetArrFromList();
else if (choice == "2") GetArrPerElem();
else Console.WriteLine("Введён неверный выбор");
