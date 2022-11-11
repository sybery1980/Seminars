
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRundomNumbers(numbers);    //iskomoe chislo v massive
WriteArray(numbers);

int searchNumber = ReadInt("Введите искомое число: ");

if(IsExist(numbers, searchNumber))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

bool IsExist(int[] array, int number)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == searchNumber)
        {
            return true;
        }
    }
    return false;
}

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