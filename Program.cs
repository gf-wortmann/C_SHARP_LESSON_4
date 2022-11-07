//задача 26 выдает количество цифр в числе
//
int GetRange(int a)
{
    int i = 0;
    while(a>1)
    {
        a /= 10;
        i++;
        Console.WriteLine($"{a}: {i}");
    }
    return i;
}

Console.Clear();
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetRange(A));