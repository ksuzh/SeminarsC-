int[,] CreateRandomTwoDemArray(int rows, int col, int min, int max)
{
    int[,] newMatrix = new int[rows, col];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < col; j++)
            newMatrix[i, j] = new Random().Next(min, max + 1);
    return newMatrix;
}

void ShowTwoDemArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива

/*
int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }
    return array
}

int[,] myArray = CreateRandomTwoDemArray(4, 5, 1, 9);
ShowTwoDemArray(myArray);

Console.WriteLine();

myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);

ShowTwoDemArray(myArray);
*/


// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
void MatrixTransposition(int[,] array)
{
    
    if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Matrix has to be square!");
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
}

int[,] myArray = CreateRandomTwoDemArray(5, 5, 1, 9);
ShowTwoDemArray(myArray);

Console.WriteLine();

MatrixTransposition(myArray);

ShowTwoDemArray(myArray);
*/


// Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

int[,] RemoveRowColumnOfMin(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int min = array[minI,minJ];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min) 
            {
                min = array[i,j];
                minI = i;
                minJ = j;
            }
        }    
    }
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, minJ] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            array[minI, j] = 0;
    
    return array;
    
}

int[,] myArray = CreateRandomTwoDemArray(5, 5, 1, 9);
ShowTwoDemArray(myArray);

Console.WriteLine();

myArray = RemoveRowColumnOfMin(myArray);
ShowTwoDemArray(myArray);
