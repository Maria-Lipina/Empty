WriteLine();
WriteLine("71. Написать программу вычисления функции Аккермана");

double Ackerman (double m, double n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return Ackerman (m-1, 1);
    return Ackerman (m-1, Ackerman(m, n-1));
}
WriteLine(Ackerman(0, 0));
WriteLine(Ackerman(2, 1));
WriteLine(Ackerman(2, 3));
WriteLine(Ackerman(3, 5));
