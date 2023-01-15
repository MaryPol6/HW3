// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
using static System.Console;
Clear();
WriteLine("Введите координаты точки А ");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());
int z1 = int.Parse(ReadLine());
WriteLine("Введите координаты точки B ");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());
int z2 = int.Parse(ReadLine());
double result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
WriteLine(result);
