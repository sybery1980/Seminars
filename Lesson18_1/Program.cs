
//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int count = ReadInt("Введите количество членов: ");  
int[] fibbonachi = new int[count];
if(count > 0)
{
    fibbonachi[0] = 0;
}

if(count > 1)
{
    fibbonachi[1] = 1;
}

for(int i = 2; i < fibbonachi.Length; i++)
{
    fibbonachi[i] = fibbonachi[i - 1] + fibbonachi[i - 2];
}

for(int i = 0; i < fibbonachi.Length; i++)
{
    Console.Write(fibbonachi[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

