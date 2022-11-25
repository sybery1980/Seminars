//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

Console.Write("Задайте число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число b: ");
int b = Convert.ToInt32(Console.ReadLine());

double Power(int a, int b)
{
    if (b == 0)
    return 1;
    else if (b > 0)
    {
        return Power(a, b - 1) * a;
    }
    else
    {
        return 1 / Power(a, - b);
    }
}
Console.WriteLine(Power(a,b));