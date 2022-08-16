using static System.Console;
using static System.Convert;

WriteLine();
WriteLine("40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");

double[] CreateArrayD(int length)
{
    return new double [length];
}

string PrintArrayD(double [] collect)
{
    string outputString = String.Empty;
    for (int pos = 0; pos < collect.Length; pos++) outputString += $"{collect[pos]} | ";
    return outputString;
}

void FillArrayD(double[] collection) // А тут войд можно и нужно, потому что метод только заполняет
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = Math.Round((new Random().NextDouble()*100), 2);
    }
}


double Findit (double [] array, string crat) //crat(erion) = 1 => find max; = 0 => find min;
{
    if (crat == "min")
    {
    double min = array[0];
        int i = 1;
        for (; i < array.Length; i++)
        {
            if (array[i] < min) min = array [i];
        }
    return min;
    }
    if (crat == "max")
    {
    double max = array[0];
        int i = 1;
        for (; i < array.Length; i++)
        {
            if (array[i] > max) max = array [i];
        }
    return max;
    }
    else return -1;
}

double [] arr3 = CreateArrayD(20);
FillArrayD(arr3);
WriteLine(PrintArrayD(arr3));

double mini = Findit(arr3, "min");
double maxi = Findit(arr3, "max");
WriteLine($"min = {mini} / max = {maxi}");
double diff = maxi - mini;
WriteLine($"difference = {diff}");