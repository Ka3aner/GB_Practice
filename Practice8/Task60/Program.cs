// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

Console.Clear();

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

int[,,] Fill3DimensionalArray(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i,j,k] = new Random().Next(-10,11);
            }
            
        }
    }
    return result;
}

void Print3DimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0,10}", $"{array[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine();  
        }
    }
}

int x = GetInt("Введите 1 размер массива");
int y = GetInt("Введите 2 размер массива");
int z = GetInt("Введите 3 размер массива");

Console.WriteLine($"Массив случайных числе размером {x} х {y} х {z}:");
Print3DimensionalArray(Fill3DimensionalArray(x, y, z));