//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//
int DigitSum(int n)
{
    int divisor = 1, accumulator=0, reminder = n;
    while (n / divisor > 0)
    {
        reminder = n % (divisor * 10) / divisor;
        accumulator += reminder;
        divisor *= 10;
    }
    return accumulator;
}
int N;
Console.Clear();
Console.WriteLine("Введите целое число");
N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits = {DigitSum(N)}");

//Console.Write(String.Join(",", a));