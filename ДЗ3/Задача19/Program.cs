// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
int N = int.Parse(Console.ReadLine()!);
int num1 = N / 10000;
int num5 = N % 10;
int num2 = N / 1000 % 10;
int num4 = N / 10 % 10;
if (num1 == num5 && num2 == num4)
{
    Console.WriteLine($"{N} полиндром");
}
else
{
    Console.WriteLine($"{N} не является полиндромом");
}