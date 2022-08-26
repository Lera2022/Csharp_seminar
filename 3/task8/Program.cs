Console.Write("Пожалуйста, введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

int index = 0;
int num = 1;
while (index < N)
{
    array[index] = num * num;
    Console.Write(array[index] + " ");
    num++;
    index++;
}
