// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortEachRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int MaxIndex = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,MaxIndex]) MaxIndex = k;
            }
            int temp = array[i, j];
            array[i,j] = array[i,MaxIndex];
            array[i, MaxIndex] = temp;
        }
    }
}

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

int[,] array = Fill2DimensionalArray(rows, columns);
Console.WriteLine("Получившийся массив случайных чисел:");
Print2DimensionalArray(array);
SortEachRow(array);
Console.WriteLine("Массив после сортировки");
Print2DimensionalArray(array);