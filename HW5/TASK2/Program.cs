// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

// [3, 7, 23, 12] -> 12
// [4, 6, 8, 1, 4] -> 6

Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("[");

int[] array = new int[N];
int sumEven = 0;
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(0, 24);
    Console.Write(array[i] + ", ");
    if ((i % 2 != 0) && (array[i] % 2 == 0))
    {
        sumEven = sumEven + array[i];
    }
    
}
Console.WriteLine("] -> " + sumEven);