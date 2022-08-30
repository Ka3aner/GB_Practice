// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] FillArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(-10,11);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i,j]);
        }
        Console.WriteLine();
    }
}

int SumOfMainDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i < array.GetLength(1)) result += array[i,i];
    }
    return result;
}

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

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

int[,] array = FillArray(rows, columns);
Console.WriteLine("Получившийся массив случайных чисел: ");
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {SumOfMainDiagonal(array)}");
