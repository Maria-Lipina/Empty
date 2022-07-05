using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("13. Выяснить, кратно ли число заданному, если нет, вывести остаток.");

bool FactorCheck (int number, int factor)
{
    if (number % factor == 0) return true;
    else return false;
}

int number3 = Convert.ToInt32(ReadLine());
Write("Проверить на кратность: ");
int factor = Convert.ToInt32(ReadLine());

if(FactorCheck(number3, factor)) WriteLine("Кратно");
else {Write("Не кратно. Остаток: " + number3 % factor);}
