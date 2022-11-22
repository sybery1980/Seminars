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

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrix(numbers);
PrintMatrix(numbers);
SortArray(numbers);
PrintMatrix(numbers);
int[,] dictionary = FrequencyDictionary(numbers);
for (int i = 0; i < dictionary.GetLength(0); i++)
{
    Console.WriteLine($"{dictionary[i, 0]} встречается {dictionary[i, 1]}");
}
int[,] FrequencyDictionary(int[,] matrix)
{
    int size = CalculateCountNumbers(matrix);
    int[,] dictionary = new int[size, 2];
    int dictionaryIndex = 0;
    dictionary[dictionaryIndex, 0] = matrix[0, 0];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (dictionary[dictionaryIndex, 0] == matrix[i, j])
                dictionary[dictionaryIndex, 1]++;
            else
            {
                dictionaryIndex++;
                dictionary[dictionaryIndex, 0] = matrix[i, j];
                dictionary[dictionaryIndex, 1] = 1;
            }
        }
    }
    return dictionary;
}
int CalculateCountNumbers(int[,] sortMatrix)
{
    int countNumbers = 1;
    int tempNumber = sortMatrix[0, 0];
    for(int i = 0; i < sortMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < sortMatrix.GetLength(1); j++)
        {
            if(tempNumber != sortMatrix[i, j])
            {
                tempNumber = sortMatrix[i, j];
                countNumbers++;
            }
        }
    }

    return countNumbers;
}
void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (matrix[a, b] < matrix[i, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[a, b];
                        matrix[a, b] = temp;
                    }
                }
            }
        }
    } 
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

int ReadInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}