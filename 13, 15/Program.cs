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


WriteLine();
WriteLine("15. Дано число. Проверить кратно ли оно 7 и 23");

int number4 = Convert.ToInt32(ReadLine());

if (FactorCheck(number4, 7) && FactorCheck(number4, 23)) WriteLine ("Кратно");
else {Console.WriteLine ("Не кратно");}