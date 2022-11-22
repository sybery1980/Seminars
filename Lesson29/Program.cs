
//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] array = new int[5,5];
FillArray(array);
Write2DArray(array);
Console.WriteLine();

int tempNumber = 0;

    for (int column = 0; column < array.GetLength(1); column++)
    {
        tempNumber = array[0,column];
         array[0,column] = array[array.GetLength(0) - 1, column];
         array[array.GetLength(0) - 1, column] = tempNumber;
    }
    Write2DArray(array);

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

