// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] FillDoubleArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(-10,10) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}", Math.Round(array[i,j],1,MidpointRounding.AwayFromZero));
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

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

Console.WriteLine("Получившийся массив случайных чисел: ");
PrintDoubleArray(FillDoubleArray(rows, columns));