//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

int number = ReadInt("Введите десятичное число: ");  
string result = String.Empty;

while(number > 0)
{
    result = number % 2 + result;
    number /= 2;
}
Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

