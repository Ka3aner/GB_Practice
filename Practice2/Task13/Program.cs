// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
string n = Math.Abs(int.Parse(Console.ReadLine())).ToString();

if (n.Length >= 3)
{
    Console.WriteLine("Третья цифра введённого числа: " + n[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
