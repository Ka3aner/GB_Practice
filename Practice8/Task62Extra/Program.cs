// Доп. задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");
int[,] array = new int[rows, columns];

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

void MoveRight(int row, int column, int counter)
{
    if (ArrayFull()) return;
    array[row, column] = counter;
    if ((column == array.GetLength(1)-1) || (array[row, column+1] != 0)) MoveDown(row + 1, column, counter + 1);
    else MoveRight(row, column + 1, counter + 1);
}

void MoveDown(int row, int column, int counter)
{
    if (ArrayFull()) return;
    array[row, column] = counter;
    if ((row == array.GetLength(0)-1) || (array[row + 1, column] != 0)) MoveLeft(row, column-1, counter+1);
    else MoveDown(row + 1, column, counter + 1);
}

void MoveLeft(int row, int column, int counter)
{
    if (ArrayFull()) return;
    array[row, column] = counter;
    if ((column == 0) || (array[row, column-1] != 0)) MoveUp(row-1, column, counter+1);
    else MoveLeft(row, column-1, counter + 1);
}

void MoveUp(int row, int column, int counter)
{
    if (ArrayFull()) return;
    array[row, column] = counter;
    if ((row == 0) || (array[row-1, column] != 0)) MoveRight(row, column+1, counter+1);
    else MoveUp(row-1, column, counter + 1);
}

bool ArrayFull()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == 0) return false;
        }
    }
    return true;
}

void Print2DimensionalArray(int[,] array)
{
    int MaxElementSize = (array.GetLength(0) * array.GetLength(1)).ToString().Length;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i,j].ToString().PadLeft(MaxElementSize, '0'));
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Получившийся массив: ");
MoveRight(0, 0, 1);
Print2DimensionalArray(array);
