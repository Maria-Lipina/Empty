using static System.Console;
using static System.Convert;

int [] FillArray1(int A)
{
int[] collect = new int [A];
for (int pos = 0; pos < collect.Length; pos++) collect[pos] = pos+1;
return collect;
}

void PrintPowers(int [] N, int power)
{
for (int i = 0; i < N.Length; i++)
{
   WriteLine($"{N[i]}^{power} = {Math.Pow(N[i], power)}");
} 
}

PrintPowers(FillArray1(ToInt32(ReadLine())),2);


WriteLine();
WriteLine("24. Найти кубы чисел от 1 до N");

PrintPowers(FillArray1(ToInt32(ReadLine())),3);
