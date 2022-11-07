//задача  заполняет массив из 8 элементов with 0 and 1
//
int[] FillArray(int[] a)
{
    Random rnd = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rnd.Next(0, 2);
    }
    return a;
}

int[] A = new int[8]; 
A = FillArray(A);
Console.Clear();
//int N = int.Parse(Console.ReadLine()!);
for (int i = 0; i < A.Length; i++)
{
    Console.Write($" {A[i]} ");
}