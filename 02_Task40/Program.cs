/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

Console.Write("Введите первую сторону: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую сторону: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью сторону: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number2 + number1) Console.WriteLine("Это треугольник");
else Console.WriteLine("Это не треугольник");