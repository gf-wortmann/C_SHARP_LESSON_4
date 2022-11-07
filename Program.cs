//задача 28 выдает произведение чисел от 1 до N
//
int GetProduct(int a)
{
    int p = 1;
    for ( int i = 1; i < a; i++) p *= i;
    return p;
}

Console.Clear();
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetProduct(N));