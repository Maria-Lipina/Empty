using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("66. Показать натуральные числа от 1 до N, N задано");

string From1toN (int n)
{
if (n != 0)
return From1toN(n-1) + " " + n;
else return string.Empty;
}

WriteLine(From1toN(10));
