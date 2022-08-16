// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

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

double Get3Dlength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
}

int x1 = GetInt("Введите x1");
int y1 = GetInt("Введите y1");
int z1 = GetInt("Введите z1");
Console.WriteLine();
int x2 = GetInt("Введите x2");
int y2 = GetInt("Введите y2");
int z2 = GetInt("Введите z2");

Console.WriteLine("Расстояние между точками в 3D пространстве = " + Math.Round(Get3Dlength(x1, y1, z1, x2, y2, z2),2,MidpointRounding.AwayFromZero));
