// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductOf2Arrays(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                for (int l = k; l < array2.GetLength(0); l++)
                {
                    resultArray[i, j] += array1[i, k] * array2[l, j];
                    break;
                }
            }
        }
    }
    return resultArray;
}


int rows = GetInt("Введите количество строк 1 массива");
int columns = GetInt("Введите количество столбцов 1 массива");

int[,] array1 = Fill2DimensionalArray(rows, columns);


int rows2 = GetInt("Введите количество строк 2 массива");
int columns2 = GetInt("Введите количество столбцов 2 массива");

int[,] array2 = Fill2DimensionalArray(rows2, columns2);

Console.WriteLine("1 массив:");
Print2DimensionalArray(array1);
Console.WriteLine("2 массив:");
Print2DimensionalArray(array2);

int[,] resultArray = ProductOf2Arrays(array1, array2);
Console.WriteLine("Произведение массивов:");
Print2DimensionalArray(resultArray);


