// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Например
// m = 2, n = 3 -> A(m,n) = 29
//           { n + 1,                   m = 0;
// A(m, n) = { A(m - 1,1),              m > 0, n = 0;
//           { A(m - 1, A(m, n - 1)),   m > 0, n > 0.
int result = 0;
int A(int m, int n)
{
    
    if (m == 0)
    {
        result = n + 1;
        return result;
    }
    else if (n == 0)
    {
        result = A((m - 1), 1);
        return result;
    }
    else
    {
        result = A((m - 1), A(m, (n - 1)));
        return result;
    }
}

Console.Write("Введите неотрицательное число от 0 до 3: m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число от 0 до 10: n = ");
int n = Convert.ToInt32(Console.ReadLine());

A(m, n);
Console.WriteLine(result);