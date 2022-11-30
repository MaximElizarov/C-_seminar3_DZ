

Console.Clear();
Console.Write("Ведите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int rev =0;
int last = 0;
int n1 = n;
while (n1 > 0)
{
    last = n1 % 10;
    rev = rev * 10 + last;
    n1 = n1 / 10;
}
if (n == rev)
    Console.Write("Yes");
else
    Console.Write("No");







// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да