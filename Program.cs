//задача 28 выдает произведение чисел от 1 до N
//
int GetProduct(int a)
{
    int p = 1;
    while( a > 1 )
    {
        p *= a;
        a--;
        Console.WriteLine($"{a}: {p}");
    }
    return p;
}

Console.Clear();
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetProduct(N));