using static System.Console;
using static System.Convert;

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int [,] collection, int minValue, int maxValue)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
       collection[i, j] = new Random().Next(minValue, maxValue + 1);  
        }
        
    }
}

string Print2DArray(int [,] collection)
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

WriteLine("48. Показать двумерный массив размером m×n заполненный целыми числами");

int[,] ar = Create2DArray(5, 6);
Fill2DArray(ar, 1, 21);
WriteLine(Print2DArray(ar));