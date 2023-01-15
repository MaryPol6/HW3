// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();
int x = int.Parse(ReadLine()); // 12421
WriteLine(x%10 == x/10000 && x%100/10 == x%10000/1000?"yes":"no");

