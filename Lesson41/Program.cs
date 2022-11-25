//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Задайте число M: ");
Console.WriteLine("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int a, int b)
{
    if(a == b)
        return b;
    else
    {
        Console.Write(NaturalNumber(a - 1, b) + ", ");
    }

    return a;
}


