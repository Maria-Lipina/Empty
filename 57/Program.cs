using static System.Console;
using static System.Convert;

WriteLine("57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");


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



void SortinRow (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int temporary = array [i,j-1];
            if (array[i,j] > temporary) 
            {
                array [i, j-1] = array[i,j]; 
                array [i, j] = temporary;
            }
        }
    }
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (array [i, j-1] < array [i,j]) SortinRow(array);
    }
}
}


int [,] ih = Create2DArray(10, 17);
Fill2DArray(ih, 0, 100);
WriteLine("Первоначальный массив");
WriteLine(Print2DArray(ih));

WriteLine("Измененный массив");
SortinRow(ih);
WriteLine(Print2DArray(ih));
