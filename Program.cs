//задача 28 выдает произведение чисел от 1 до N
//
int GetProduct(int a)
{
    int p = 1, i = 1;
    while( a > i )
    {
        p *= i;
        i++;
        Console.WriteLine($"{i}: {p}");
    }
    return p;
}

Console.Clear();
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetProduct(N));