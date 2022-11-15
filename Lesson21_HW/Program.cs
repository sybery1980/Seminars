//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)


class Magic
{
static void Main()
  {
    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());
    double x = (b1-b2)/(k2-k1);
    double y = (k2 * x + b2);
    Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
  }
}