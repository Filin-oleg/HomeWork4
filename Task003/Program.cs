// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void randomArrayfill (int arrLenght, int min, int max)
{
    int[] array = new int[arrLenght];
    for (int i = 0; i < arrLenght; i++)
    {
        array[i] = new Random().Next(min, max);
        Console.Write(array[i] + " ");
    }
}
randomArrayfill (8, 1, 10);
Console.WriteLine("");