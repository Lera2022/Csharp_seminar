// Задача 3. Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

Console.Write("Введите число строк в массиве: m = ");
int m = Convert.ToInt32(Console.ReadLine());
int tmp = 50 / m;
Console.Write("Введите число столбцов в массиве от 1 до " + tmp + ": n = ");
int n = Convert.ToInt32(Console.ReadLine());



bool Contains(int[,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (value == arr[i, j])
            {
                return true;
            }
        }
    }
    return false;
}

int[,] nums = new int[m, n];
Random ran = new Random();
int temp = 1;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        temp = ran.Next(10, 100);
        do
        {
            temp = ran.Next(10, 100);
        }
        while (Contains(nums, temp));
        nums[i, j] = temp;
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}

