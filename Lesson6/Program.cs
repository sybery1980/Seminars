//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void setValue(int[] syb, int index)
 {
     Console.WriteLine("Введите значение индекса " + index);
     syb[index] = Convert.ToInt32(Console.ReadLine());
 }

 int[] syb = new int[9];
 for (int index = 0; index < syb.Length; index++) 
 {
     setValue(syb, index);
 }
 string output = $"{syb[0]}";
 for (int index = 1; index < syb.Length - 1; index++)
  {
     output += $", {syb[index]}";
  }
 output += $", {syb[8]}";

 Console.WriteLine("Массив: " + output);