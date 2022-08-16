// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = int.Parse(Console.ReadLine());

double Method(int numberA, int numberB)
{
    int numberC = 1;
    for (int i = 1; i <= numberB; i++)
    {
        numberC = numberC * numberA;
    }
    return numberC;
}
Console.WriteLine("Первое число возведенное в степень второго числа = " + Method(numA, numB));