using static System.Console;
using static System.Convert;

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

string FindIndexes(int N, int[,] array)
{
    string found = $"Индексы {N} в массиве: ";
    int startLen = found.Length;
    string notfound = "-1";

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == N) found = found + $"{i}, {j}; ";
    }   
}
if (found.Length > startLen) return found;
else return notfound;
}

WriteLine("53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");

int [,] ab = Create2DArray(6, 10);
Fill2DArray(ab, 0, 10);
WriteLine(Print2DArray(ab));

WriteLine(
    FindIndexes(
        ToInt32(ReadLine()), ab));