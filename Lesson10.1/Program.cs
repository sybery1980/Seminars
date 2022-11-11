int size = 123;  //pokazivaet skolko chisel v massive v diapozone ot 10 do 99
int[] numbers = new int[size];
int min = 10;
int max = 99;
int count = 0;
FillArrayRandomNumbers(numbers, 0, 130);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min || numbers[i] > max)
        continue;
    
    count++;
}
Console.WriteLine(count);


void FillArrayRandomNumbers(int[] array, int min = 1, int max = 9)
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
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}