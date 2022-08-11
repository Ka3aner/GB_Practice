// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int n = Math.Abs(int.Parse(Console.ReadLine()));

if ((n < 100) | (n > 999))
{
    Console.WriteLine("Нужно ТРЁХЗНАЧНОЕ число. Попробуйте снова");
}
else
{
    int x = (n % 100) / 10;
    Console.WriteLine(x);
}
