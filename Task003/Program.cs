// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void randomArrayfill (int arrLenght)
{
    int[] array = new int[arrLenght];
    for (int i = 0; i < arrLenght; i++)
    {
        array[i] = new Random().Next(1, 10);
        Console.Write(array[i] + " ");
    }
}
randomArrayfill (8);
Console.WriteLine("");