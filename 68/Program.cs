using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("68. Показать натуральные числа от M до N, N и M заданы");

string FromMtoN (int m, int n)
{
if (n > m) return m + " " + FromMtoN(m + 1, n);
if (n < m) return m + " " + FromMtoN(m - 1, n);
return n.ToString();
}

WriteLine(FromMtoN(10, 30));
WriteLine(FromMtoN(30, 10));
