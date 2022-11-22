//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
 //В случае, если это невозможно, программа должна вывести сообщение для пользователя.

 int[,] array = new int[5,6];
FillArray(array);
Write2DArray(array);
Console.WriteLine();

int[,] array2 = new int[array.GetLength(1),array.GetLength(0)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[j,i] = array[i, j];
    }
}
Write2DArray(array2);

int[,] FillArray(int [,] array, int min = 0, int max = 10)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        
            array[i,j] = new Random().Next(min,max+1);
    }
    return array;
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

