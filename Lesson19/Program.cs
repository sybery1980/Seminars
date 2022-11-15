//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] numbers = new int[8];
int[] numbers2 = new int[8];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10 + 1);
}
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    numbers2[i] = numbers[i];

}
WriteArray(numbers2);

void WriteArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

