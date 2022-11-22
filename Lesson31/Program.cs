//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
//1, 2, 3 
//4, 6, 1 
//2, 1, 6
//1 встречается 3 раза 
//2 встречается 2 раз 
//3 встречается 1 раз 
//4 встречается 1 раз 
//6 встречается 2 раза

int[,] array = {{1, 2, 3},{4, 6, 1},{2, 1, 6}};


int max = array[0,0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] > max)
        {
            max = array[i,j];
        }
    }
}
int[] count = new int[max+1];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
     count[array[i,j]]++;
        
    }
}
for (int j = 0; j < max+1; j++)
{
    if (count[j]!=0)
Console.WriteLine($"количество {j} - {count[j]}");
}
    