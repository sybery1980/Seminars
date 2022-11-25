//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.WriteLine("Количество листов: ");
 int lists = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Количество строк: ");
 int rows = int.Parse(Console.ReadLine()!);
 Console.WriteLine("Количество столбцов: ");
 int columns = int.Parse(Console.ReadLine()!);
 Console.WriteLine();

 
 int minRandom = 12;
 int maxRandom = 99;

 int[,,] matrix = GetMatrix(rows, columns, lists, minRandom, maxRandom); 
 PrintIndexMatrix(matrix);
 Console.WriteLine();

 int[,,] GetMatrix(int row, int colmn, int list, int min, int max) 
 {
     int[,,] array = new int[lists, rows, columns];
     var rnd = new Random();
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             for (int k = 0; k < array.GetLength(2); k++)
             {
                 if (minRandom<=maxRandom)
                 {
                     array[i, j, k] = minRandom;
                     minRandom++;
                 }
                 else
                 {
                    Console.WriteLine("Программа не расчичитана на генерацию массивов с числами больше 99");
                 }
             }
         }
     }
     return array;
 }

 void PrintIndexMatrix(int[,,] array) 
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         Console.WriteLine((i ++));
         for (int j = 0; j < array.GetLength(1); j++)
         {
             for (int k = 0; k < array.GetLength(2); k++)
             {
                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
             }
             Console.WriteLine();
         }
         Console.WriteLine();
     }
 }