using static System.Console;
using static System.Convert;

int [] Digits(int n)
{
    int [] result = new int [Convert.ToString(n).Length];
    if (n == 0) result [0] = n;
    else
    {
        for (int i = 0; i < result.Length; i++)
        {
            int o = n % 10;
            result[i] = o; // не совсем очевидно, но можно догадаться, что полностью строка будет result = result + o
            n /= 10;
        }
    }
    return result;
}

int ArraySum (int[] A)
{int sum = 1;
for (int i = 1; i < A.Length; i++)
{
    sum = sum + A[i];
}
return sum;
}

int [] digs = Digits(ToInt32(ReadLine()));

WriteLine("27. Определить количество цифр в числе");

WriteLine(digs.Length);

WriteLine();
WriteLine("28. Подсчитать сумму цифр в числе");

WriteLine(ArraySum(digs));