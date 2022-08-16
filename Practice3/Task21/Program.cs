int GetInt(string message)
{
    Console.Write(message+": ");
    string str = Console.ReadLine();
    int number;
    if (int.TryParse(str, out number)) return number;
    else
    {
        Console.WriteLine("Введено не целое число, повторите ввод");
        GetInt(message);
    }
    return 0;
}
