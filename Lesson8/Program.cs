int[] numbers = {-4,-8,8,2}; //massiv perevernut v otricatelnoe chislo

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i]*= -1;
}
WriteArray(numbers);
void WriteArray(int[] array)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}    

