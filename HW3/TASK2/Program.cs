// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.Write("Пожалуйста, введите координату Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите координату Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());
Console.Write("A (" + xa + ", " + ya + ", " + za + "); B (" + xb + ", " + yb + ", " + zb + ")");
double ab =  Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
Console.Write(", -> " + ab);