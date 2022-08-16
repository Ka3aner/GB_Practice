// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

Console.WriteLine("Введите пятизначное число для проверки");

string str = Console.ReadLine();
string strabs = Math.Abs(int.Parse(str)).ToString();
string answer = "Данное число является палиндромом";

for(int i = 0; i < strabs.Length; i++)
{
    if (strabs[i] != strabs[strabs.Length-1-i])
    {
        answer = "Данное число НЕ является палиндромом";
        break;
    }
}

Console.WriteLine(answer);