// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки 1. x, y, z поочередно");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2. x, y, z поочередно");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double l = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.Write("Расстояние между данными точками = ");
Console.WriteLine("{0:0.##}", l);
