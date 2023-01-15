//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear();
int x = int.Parse(ReadLine());
int y = 1;

while(y<=x)
{
    WriteLine(Math.Pow(y,3));
    y+=1;
}