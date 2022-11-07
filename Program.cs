//задача 30 заполняет массив из 8 элементов with 0 and 1
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
FillArray(A);
Console.Clear();

//for (int i = 0; i < A.Length; i++)
//{
    //Console.Write($" {A[i]} ");
//}

//Console.WriteLine(" ");
Console.Write(String.Join(", ", A));