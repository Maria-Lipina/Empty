using static System.Console;
using static System.Convert;

WriteLine("56. Написать программу, которая обменивает элементы первой строки и последней строки");

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

void Change1stLastRows (int [,] array)
{
int[,] firstRow = new int[1, array.GetLength(1)];
int[,] lastRow = new int[1, array.GetLength(1)];

Array.Copy(array, 0, firstRow, 0, array.GetLength(1));
Array.Copy(array, array.Length - array.GetLength(1), lastRow, 0, array.GetLength(1));
Array.Copy(lastRow, 0, array, 0, lastRow.Length);
Array.Copy(firstRow, 0, array, array.Length - array.GetLength(1), firstRow.Length);
}


int[,] fg = Create2DArray(7, 12);
Fill2DArray(fg, 10, 100);
WriteLine(Print2DArray(fg));
Change1stLastRows(fg);
WriteLine(Print2DArray(fg));