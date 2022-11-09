
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16 (Homework)



Console.Write ("Введите A: ");
int a = int.Parse (Console.ReadLine ()!); 


Console.Write ("Введите B: ");
int b = int.Parse (Console.ReadLine ()!);

int syb = a;

for (int i = 1; i < b; i++) 
  syb = syb * a;

 Console.WriteLine($"Число {a} в степени {b} равно {syb}");
