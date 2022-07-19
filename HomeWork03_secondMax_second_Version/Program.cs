// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.WriteLine("Введите длину массива");
int i = Convert.ToInt32(Console.ReadLine());
while (i < 3)
{
    Console.WriteLine("Вы ввели не верную длину массива. Массив должен состоять из более, чем 2х элемпентов");
    i = Convert.ToInt32(Console.ReadLine());
}
int[] A = new int[i];
int a = 0;
while (a <= i - 1)
{
    Console.WriteLine("Введите элемент массива " + (a + 1));
    A[a] = Convert.ToInt32(Console.ReadLine());
    a = a + 1;
}
Console.WriteLine("[{0}]", string.Join(", ", A));

int index = 2;
int max;
int max2;
if (A[0] == 0 || A[1] == 0)
    Console.WriteLine("Условия задачи не выполнены. До 0 меньше 2х значений");
else
{
    if (A[0] > A[1])
    {
        max = A[0];
        max2 = A[1];
    }
    else
    {
        max2 = A[0];
        max = A[1];
    }
    while (index < i)
    {
        if (A[index] == 0)
        index=i;
        else 
        {
            if (A[index] > max)
            {
                max2 = max;
                max = A[index];
            }
            else
                if (A[index] > max2)
                    max2 = A[index]; 
            index++;
        }
    }
    Console.WriteLine("Второе по величине число это - " + max2);
}
