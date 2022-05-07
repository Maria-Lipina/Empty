using static System.Console;
using static System.Convert;
using static System.Math; 

// Директива "using namespace" может применяться только к пространствам имен; "Math" является типом, а не пространством имен. Используйте директиву "using static"

WriteLine("5. Написать программу вычисления значения функции y=sin(a)");

WriteLine(Sin(ToDouble(ReadLine())));
