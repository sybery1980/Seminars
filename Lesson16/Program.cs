//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.



Console.WriteLine ($"Введите число:  ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Введите число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ($"Введите число:  ");
int c = Convert.ToInt32 (Console.ReadLine());
if (a<(b+c) && b< (a+c) && c<(b+a))
Console.WriteLine("Треугольник существует");
else
Console.WriteLine("Треугольник не существует");

