//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int num) 
{
  if(num < 10)
  return num;
  else
  return (num % 10) + Sum(num / 10);
    

}
Console.WriteLine(Sum(number));