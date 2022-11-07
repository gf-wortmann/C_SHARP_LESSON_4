//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//
long Pow(int n, int p)
{
    long res=n;
    for (int i = 1; i < p; i++)
    {
        res *= n;
    }
    return res;
}

int N, P;

Console.Clear();
Console.WriteLine("Введите целое число");
N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите целочисленный показатель степени");
P = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} в степени {P} = {Pow(N, P)}");

//Console.Write(String.Join(", ", A));