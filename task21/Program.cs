/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты х для А: ");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y для А: ");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z для А: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты х для B: ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y для B: ");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z для B: ");
double zb = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
d = Math.Round(d, 2);
Console.Write($"расстояние = {d}");

