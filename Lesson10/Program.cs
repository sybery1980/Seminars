int n = 5;  //pokazivaet kolichestvo chisel v massive ot 10 do 99 
int min = 10;
int max = 99;
int count = 0;
int[] numbers = new int[n];

for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(min, max + 1);
    }
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= 10 && numbers[i] <= 99)
    count++;
}
Console.WriteLine(count);