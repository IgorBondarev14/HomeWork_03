// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел
// от 1 до N.

Console.WriteLine("Введите любое число");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= a; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        
    }
Console.WriteLine(" ");
