Console.WriteLine("Введите число"); //factorial
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= number; i++)
{
    result = result * i;
}
Console.WriteLine(result);
