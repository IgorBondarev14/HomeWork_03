// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.


int[] array = { 199, 100, 11, 110, 12, 0, 77, 10, 68 };
int n = array.Length;
int index = 2;
int max;
int max2;
if (array[0] == 0 || array[1] == 0)
    Console.WriteLine("Условия задачи не выполнены. До 0 меньше 2х значений");
else
{
    if (array[0] > array[1])
    {
        max = array[0];
        max2 = array[1];
    }
    else
    {
        max2 = array[0];
        max = array[1];
    }
    while (index < n)
    {
        if (array[index] == 0)
        index=n;
        else 
        {
            if (array[index] > max)
            {
                max2 = max;
                max = array[index];
            }
            else
                if (array[index] > max2)
                    max2 = array[index]; 
            index++;
        }
    }
    Console.WriteLine("Второе по величине число это - " + max2);
}
