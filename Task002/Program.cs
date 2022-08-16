// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int Number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + number % 10;
        number = number / 10;
    }
    return summ;
}
Console.WriteLine("Сумма цифр в введенном Вами числе = " + Sum(Number));