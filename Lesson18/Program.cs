//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int count = ReadInt("Введите количество членов: ");  
int first = 0;
int second = 1;

if(count > 0)
{
    Console.Write(first + " ");
}

if(count > 1)
{
    Console.Write(second + " ");
}

for(int i = 2; i < count; i++)
{
    int next = first + second;
    first = second;
    second = next;
    Console.Write(next + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
