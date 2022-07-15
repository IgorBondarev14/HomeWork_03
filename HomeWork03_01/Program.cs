// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
S:
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 10000 || a > 99999)
{
    Console.WriteLine("Введено не пятизначное число. Повторите ввод");
    goto S;
}
string astr = Convert.ToString(a);
if (astr[0] == astr[4])
{
    if (astr[1] == astr[3])
        Console.WriteLine("Введенное число является палиндромом");
    else
        Console.WriteLine("Введенное число НЕ является палиндромом");
}
else
Console.WriteLine("Введенное число НЕ является палиндромом");
