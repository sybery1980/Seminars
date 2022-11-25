﻿
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int size = RedInt("Задайте размер массива: ");
int[,] numbers = new int[size, size];
int value = 1;
int i = 0;
int j = 0;

while(value <= size * size)
{
    numbers[i, j] = value++;
    if(i <= j + 1 && i + j < size - 1) 
        j++;
    else if(i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
}

for(int k = 0; k < numbers.GetLength(0); k++)
{
    for(int l = 0; l < numbers.GetLength(1); l++)
    {
        Console.Write(numbers[k, l] + " ");
    }
    Console.WriteLine();
}

int RedInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}