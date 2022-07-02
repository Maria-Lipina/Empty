using static System.Console;
using static System.Convert;

void PrintArray(int[] collect)
{
    for (int pos = 0; pos < collect.Length; pos ++) Write($"{collect[pos]} ");
    WriteLine();
    WriteLine();
}

int [] FillArray(int N)
{
int[] collect = new int[N+N+1];
for (int pos = 0; pos < collect.Length; pos++) 
{
    collect[pos] = -N;
N--; // тот самый момент, когда сначала написал код и только потом понял, почему он работает как надо.
}
return collect;
}
PrintArray(FillArray(ToInt32(ReadLine())));
