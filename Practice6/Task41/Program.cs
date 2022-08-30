// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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

int SumofPositiveFromString()
{
    int counter = 0;
    Console.WriteLine("Введите числа через запятую в формате: 'x1, x2, ..., xn'");
    string[] numbers = Console.ReadLine().Split(", ");
    foreach (string number in numbers) if (int.Parse(number) > 0) counter++;
    return counter;
}

int SumofPositiveFromNumbers()
{
    int counter = 0;
    while (true)
    {
        Console.WriteLine("Введите число. Если вы закончили ввод - введите 'Q'");
        string input = Console.ReadLine();
        if ((input == "Q") | (input == "q")) return counter;
        if (int.TryParse(input, out int number)) 
        {
            if (number > 0) counter++;
        }
        else Console.WriteLine("Введённая строка не является числом");
    }
}

string message ="Введите '1', если хотите ввести числа через запятую\n" +
                "Введите '2', если хотите ввести числа через Enter\n" +
                "Ваш выбор";


int choice = GetInt(message);
if (choice == 1) Console.WriteLine("Количество чётных элементов = " + SumofPositiveFromString());
else if (choice == 2) Console.WriteLine("Количество чётных элементов = " + SumofPositiveFromNumbers());
else Console.WriteLine("Введён неверный выбор, перезапустите программу");


