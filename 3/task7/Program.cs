//1. Create array
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];// 10, 100, 1000

//2. Заполнение массива
int index = 0;
while (index < N)
{
    array[index] = new Random().Next(1, 11);
    Console.WriteLine(array[index] + " ");
    index++;
}

//Average (Mean)
double sum = 0;
for (int i = 0; i < N; i++)
{
    sum += array[i];
}
double mean = sum / N;
Console.WriteLine(mean);
