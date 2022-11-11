int size = ReadInt("Введите размер массива: ");//делать массив отрицательм
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers, -10, 10);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
}
WriteArray(numbers);

void FillArrayRundomNumbers(int[] array, int min = 1, int max = 9)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
