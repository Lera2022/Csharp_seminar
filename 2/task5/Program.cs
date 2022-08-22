int a = new Random().Next(100,1000);
Console. WriteLine(a);
int digit_first = a / 100;
int digit_third = a %10;
int b = digit_first*10 + digit_third;
Console. WriteLine(b);

//Console. WriteLine(digit_first + " " + digit_last);
//Console. WriteLine(digit_first.ToString() + digit_last.ToString());
//Console. Write(digit_first);
//Console. Write(digit_last);