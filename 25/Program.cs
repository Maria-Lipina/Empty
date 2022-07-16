using static System.Console;
using static System.Convert;

int [] FillArray1(int A)
{
int[] collect = new int [A];
for (int pos = 0; pos < collect.Length; pos++) collect[pos] = pos+1;
return collect;
}

WriteLine();
WriteLine("25. Найти сумму чисел от 1 до А");

int ArraySum (int[] A)
{int sum = 1;
for (int i = 1; i < A.Length; i++)
{
    sum = sum + A[i];
}
return sum;
}

WriteLine(ArraySum(FillArray1(ToInt32(ReadLine()))));


