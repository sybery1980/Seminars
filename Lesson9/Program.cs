int[] numbers = {6,7,19,345,3};//pokazivaet est li chislo v massive
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == x)
    {
        Console.WriteLine("Yes");
        return;
    }
    
}
Console.WriteLine("No");
