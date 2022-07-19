using static System.Console;
using static System.Convert;

int [] FillArray1(int A)
{
int[] collect = new int [A];
for (int pos = 0; pos < collect.Length; pos++) collect[pos] = pos+1;
return collect;
}

WriteLine("29. Написать программу вычисления произведения чисел от 1 до N");

long ArrayProduct (int[] A)
{long prod = A[0];
for (int i = 1; i < A.Length; i++)
{
prod = prod * A[i];
}
return prod;
}

WriteLine(ArrayProduct(FillArray1(ToInt32(ReadLine()))));
