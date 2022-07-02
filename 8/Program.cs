using static System.Console;
using static System.Convert;

WriteLine("8. Показать четные числа от 1 до N");

int[] SelectEvens(int n)
{
int [] result = new int [n];
int len = 0;

for (int i = 0; i<= result.Length; i++)
{
    if (i%2==0)
    {
    result [len] = i;
    len++;
    }
}
Array.Resize(ref result, len);
return result;
}

void PrintArray(int[] collect)
{
    for (int pos = 0; pos < collect.Length; pos ++) Write($"{collect[pos]} ");
    WriteLine();
    WriteLine();
}

PrintArray(SelectEvens(ToInt32(ReadLine())));