using static System.Console;
using static System.Convert;

WriteLine("44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы");

double LineCross(double x, double step, double k1, double k2, double b1, double b2)
{
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;

if (y1 == y2) return x;
else return LineCross(x+step, step, k1, k2, b1, b2);
}

WriteLine(LineCross(0, 0.1, -3, 2, 5, 4));
