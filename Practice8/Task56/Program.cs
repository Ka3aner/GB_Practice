// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[,] Fill2DimensionalArray(int rows, int columns)
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

void Print2DimensionalArray(int[,] array)
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

int FindMinSumOfRow(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма элементов {i+1} строки = {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    return minRow;
}

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

int[,] array = Fill2DimensionalArray(rows, columns);
Console.WriteLine("Получившийся массив случайных чисел:");
Print2DimensionalArray(array);
Console.WriteLine($"Наименьшая сумма элементов в {FindMinSumOfRow(array)+1} строке");