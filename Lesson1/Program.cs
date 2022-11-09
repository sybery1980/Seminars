Console.WriteLine("Введите число");           //считаем  количество чисел в числе
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(number > 1)
{
    number = number / 10;
    count++;
}
Console.WriteLine(count);
