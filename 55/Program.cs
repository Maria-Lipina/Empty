using static System.Console;
using static System.Convert;

WriteLine("55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] collection, int minValue, int maxValue)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
}

string Print2DArray(int[,] collection)
{
    string outputString = String.Empty;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            outputString += $"{collection[i, j]} | ";
        }
        outputString += "\n";
    }
    return outputString;
}

string PrintMyArray(int[] collect)
{
    string outputString = String.Empty;
    for (int pos = 0; pos < collect.Length; pos++) outputString += $"{collect[pos]} ";
    return outputString;
}

int [] ColumnAverage (int [,] arr)
{
int [] result = new int [arr.GetLength(1)];
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
    result [j] = (result [j] + arr [i,j]);
}
}
for (int i = 0; i < result.Length; i++) result[i] = result[i] / arr.GetLength(0);

return result;
}

string CutOff (int [,] arr)
{
string line = string.Empty;
for (int i = 0; i < arr.GetLength(1); i++)
{
    line += $"-- | ";
}
return line;
}

int [,] ef = Create2DArray(7, 12);
Fill2DArray(ef, 10, 100);
WriteLine(Print2DArray(ef));
WriteLine(CutOff(ef));
WriteLine(
    PrintMyArray(
        ColumnAverage(ef)));
