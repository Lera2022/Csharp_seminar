int get_factorial(int x)
{
    Console.WriteLine(x);
    if (x == 1)
    {
        Console.WriteLine("IF");
        return 1;
    }
    else 
    {
        int tmp = get_factorial(x - 1);
        Console.WriteLine("reverse: " + tmp);
        return x * tmp;
    }
}

int x = get_factorial(4);
Console.WriteLine(x);