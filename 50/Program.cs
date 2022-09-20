using static System.Console;
using static System.Convert;

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
        for (int j = 0; j < collection.GetLength(1); j++) // И помни, что длина строки определяется количеством столбцов. И наоборот длина столбца определяется количеством строк.
        {
            outputString += $"{collection[i, j]} | ";
        }
        outputString += "\n";
    }
    return outputString;
}

void ChangeEvens(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0)
            {
                arr[i, j] = -arr[i, j];
            }
        }
    }
}

WriteLine("50. В двумерном массиве n*k заменить четные элементы на противоположные");

int[,] ar = Create2DArray(5, 6);
Fill2DArray(ar, 1, 21);
ChangeEvens(ar);
WriteLine(Print2DArray(ar));
