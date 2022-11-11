int size = ReadInt("Введите размер массива: ");//est li chislo v massive iskomoe
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers);
WriteArray(numbers);

int searchNumber = ReadInt("Введите искомое число: ");
string output = "Нет";
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == searchNumber)
    {
        output = "Да";
        break;
    }
}
Console.WriteLine(output);

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