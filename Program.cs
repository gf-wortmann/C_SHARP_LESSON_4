//ЗЗадача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//
//6, 1, 33 -> [6, 1, 33]
//
int[] GetArray(int n)
{
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введште целое число №{i+1} из 8");
        a[i] = int.Parse(Console.ReadLine()!);
    }
    return a;
}

int N = 8;
Console.Clear();
Console.Write(String.Join(", ", GetArray(N)));