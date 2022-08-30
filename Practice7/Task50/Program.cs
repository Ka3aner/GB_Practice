// Задача 50. Напишите программу, которая на вход принимает число, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void PrintNumberIndex(int number, int[,] array)
{
    bool isIndex = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number) 
            {
                Console.WriteLine($"Индекс [{i},{j}] - значение {array[i,j]}");
                isIndex = true;
            }
        }
    }
    if (isIndex == false) Console.WriteLine($"В данном массиве нет индекса со значением {number}");

}

int rows = GetInt("Введите количество строк массива");
int columns = GetInt("Введите количество столбцов массива");

int[,] array = FillArray(rows, columns);
Console.WriteLine("Получившийся массив случайных чисел: ");
PrintArray(array);
int number = GetInt("Введите число, индексы которого хотите найти");
PrintNumberIndex(number, array);
