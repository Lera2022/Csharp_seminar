// 1. Input num
int num = Convert.ToInt32(Console.ReadLine());
// 2. Get number length in digits
int countOfDigits = 0;
int tmp = num;
while (tmp > 0)
{
    tmp = tmp / 10;
    countOfDigits++;
}
// 3. Create array with required size
int [] digits;
digits = new int [countOfDigits];

// 4. Fill array digits
int i = 0;
while (num > 0)
{
    digits[i] = num % 10;
    num = num / 10;
    Console.Write(digits[i]);
    i++;
}
