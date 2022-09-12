// Разработать функцию с параметром, которая изменяет значение передаваемого в неё документа. Функция имеет возвращаемый вид void.
void IncrementValue(ref int a)
{
    a++;
    //Console.WriteLine("In IncrementValue:" + a);
}

int val = 5;
IncrementValue(ref val);
Console.WriteLine(val);