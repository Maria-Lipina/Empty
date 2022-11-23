using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("67. Показать натуральные числа от N до 1, N задано");

string FromNto1 (int n)
{
if (n != 0)
return n + " " + FromNto1(n-1);
else return string.Empty;
}

WriteLine(FromNto1(10));