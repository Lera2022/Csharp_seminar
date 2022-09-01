// Задайте произвольный целочисленный массив. Напишите программу, которая определяет, присутствует ли заданное пользователем число в массиве
int N = 10;
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Find(int num)
{
    for (int i = 0; i < N; i++)
    {
        if (array[i] == num)
        {
            Console.WriteLine("да");
        }
    }

}
Find(num);
