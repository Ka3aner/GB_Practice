// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrinAverageOfRows(int[,] array)
{
    double sumOfRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sumOfRow += array[i,j]; 
        }
        Console.WriteLine($"Среднее арифмитическое элементов {j+1} столбца = " +
                        $"{Math.Round(sumOfRow/array.GetLength(0),3,MidpointRounding.AwayFromZero)}");
        sumOfRow = 0;
    }
}

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

int[,] array = FillArray(rows, columns);
Console.WriteLine("Получившийся массив случайных чисел: ");
PrintArray(array);
PrinAverageOfRows(array);