using static System.Console;
using static System.Convert;

WriteLine("6. Выяснить является ли число чётным");

bool b = (ToInt32(ReadLine()) % 2) == 0;
WriteLine(b);