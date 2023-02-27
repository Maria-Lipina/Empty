using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("69. Найти сумму элементов от M до N, N и M заданы");

int SumFromMtoN(int m, int n)
{
    if (n < m)
    {     
       return m + SumFromMtoN(m - 1, n);
    }
    if (m < n)
    {
        return n + SumFromMtoN(m, n-1); 
    }
    return n;
}

WriteLine(SumFromMtoN(10, 30)); 
WriteLine(SumFromMtoN(30, 10));
