using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");

int Min = -100;
int Max = 100;

int [] RandomDot (int D, int range) //range - четверть или октант.
{int [] dot = CreateMyArray(D);
if (D == 2 || D == 3)
{   
    // для определения х
    if (range == 1 || range == 4 || range == 5 || range == 8) dot [0] = new Random().Next(0, Max);
    if (range == 2 || range == 3 || range == 6 || range == 7) dot [0] = new Random().Next(Min, 0);
    //для определения у
    if (range == 1 || range == 2 || range == 5 || range == 6) dot [1] = new Random().Next(0, Max);
    if (range == 3 || range == 4 || range == 7 || range == 8) dot [1] = new Random().Next(Min, 0);
}
 if (D == 3)
 {  //для определения z
    if (range == 1 || range == 2 || range == 3 || range == 4) dot [2] = new Random().Next(0, Max);
    if (range == 5 || range == 6 || range == 7 || range == 8) dot [2] = new Random().Next(Min, 0);
 }
return dot;
}

int range (int [] dot)
{
switch (dot[0], dot[1])
{
case (> 0, > 0): return 1;
case (< 0, > 0): return 2;
case (< 0, < 0): return 3;
case (> 0, < 0): return 4;
default: return 0;
};
}

int [] Dottocheck = RandomDot(2, 2);
WriteLine(range(Dottocheck));


WriteLine();
WriteLine("20. Задать номер четверти, показать диапазоны для возможных координат");

string ShowRange (int range)
{string Show = $"В четверти {range} Х принимает значения";

   // для определения х
    if (range == 1 || range == 4) Show += $" положительных чисел от 0 до {Max}. Y принимает значения";
    if (range == 2 || range == 3) Show += $" отрицательных чисел от {Min} до 0. Y принимает значения";
    //для определения у
    if (range == 1 || range == 2) Show += $" положительных чисел от 0 до {Max}.";
    if (range == 3 || range == 4) Show += $" отрицательных чисел от {Min} до 0.";
return Show;
}
WriteLine(ShowRange(4));


WriteLine();
WriteLine("22. Найти расстояние между точками в пространстве 2D/3D");

int [] DotA = RandomDot(3, 1);
WriteLine (PrintMyArray(DotA));

int [] DotB = RandomDot(3, 1);
WriteLine (PrintMyArray(DotB));


double distance(int D, int[] A, int[] B)
{
double distance = 0;
if (D == 2) 
{
   return distance = Math.Sqrt(Math.Pow((B[0] - A[0]),2) + Math.Pow((B[1] - A[1]),2));
}
if (D == 3) 
{
   return distance = Math.Sqrt(Math.Pow((B[0] - A[0]),2) + Math.Pow((B[1] - A[1]),2)+ Math.Pow((B[2] - A[2]),2));
}
return distance;
}

double dist = distance(2, DotA, DotB);
WriteLine(dist);
