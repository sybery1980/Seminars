//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int[] multiplies;

FillArrayRandomNumbers(numbers);
WriteArray(numbers);

if(numbers.Length % 2 == 0)
{
    multiplies = new int[numbers.Length / 2];
}
else
{
    multiplies = new int[numbers.Length / 2 + 1];
    multiplies[multiplies.Length - 1] = numbers[numbers.Length / 2]; 

}
 
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        multiplies[i] =numbers[i] * numbers[numbers.Length -1 - i];
    }
 WriteArray(multiplies);

void FillArrayRandomNumbers(int[] array, int min = 0, int max = 10)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    
 }
 void WriteArray(int[] arr)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
 }

