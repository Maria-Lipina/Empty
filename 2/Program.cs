using static System.Console;
using static System.Convert;

WriteLine("2. Даны два числа. Показать большее и меньшее число");

void Compare (int x, int y)
{
if (y>x) Console.WriteLine(y + " больше " + x);
else Console.WriteLine(x +" больше "+ y);
}

int x3 = ToInt32(ReadLine());
int x4 = ToInt32(ReadLine());
Compare(x3, x4);
