//Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
//
void DrawFir(int n)
{
    char[] a = new char[2 * n - 1];
    int centerindex = n - 1; 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n-i; j++){ a[j] = ' ';}
        for (int j = 0; j <= i; j++){ a[centerindex + j] = a[centerindex-j] = '*';}
        Console.WriteLine(String.Join("", a));
    }
}

int N = 8;
Console.Clear();
Console.WriteLine("Введите высоту ёлочки");
N = int.Parse(Console.ReadLine()!);
if (N > 40){Console.WriteLine($"Многовато, максимальная высоте = 40"); return;}
DrawFir(N);