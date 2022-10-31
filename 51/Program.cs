using static System.Console;
using static System.Convert;

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

string Print2DArray(int[,] collection)
{
    string outputString = String.Empty;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++) // И помни, что длина строки определяется количеством столбцов. И наоборот длина столбца определяется количеством строк.
        {
            outputString += $"{collection[i, j]} | ";
        }
        outputString += "\n";
    }
    return outputString;
}


WriteLine("51. Задать двумерный массив следующим правилом: Aₘₙ = m+n");


void FillIndexSums (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i + j;
    }
}
}
int[,] mn = Create2DArray(6, 10);
FillIndexSums(mn);
WriteLine(Print2DArray(mn));
