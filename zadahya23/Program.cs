Console.Clear();
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 1;
while (k <= n)
{
    Console.WriteLine(Math.Pow(k, 3));
    k++;
}



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125