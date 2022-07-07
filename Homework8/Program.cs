
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

// Задача 54
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки 
//двумерного массива.

/*
int[,] SortRowsMinToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            if (array[i,k+1] < array[i,k])
            {
                int temp = array[i,k +1];
                array[i,k+1] = array[i,k];
                array[i,k] = temp;
            }
        }
    }
    return array;
}


int[,] myArray = CreateRandomTwoDemArray(5, 5, 1, 9);
ShowTwoDemArray(myArray);
Console.WriteLine();
myArray = SortRowsMinToMax(myArray);
ShowTwoDemArray(myArray);
*/

// Задача 56
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

/*
int SumOfRow(int[,] array, int i)
{
    int RowSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
        RowSum += array[i,j];
    return RowSum; 
}

void FindMinSumRow(int[,] array)
{
    int min = 0;
    int sumFirstRow = SumOfRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow = SumOfRow(array, i);
        if (sumRow < sumFirstRow) 
        {
            min = i;
            sumFirstRow = sumRow;
        }
    }
    Console.WriteLine($"The row with min sum is {min + 1}");
        
}


int[,] myArray = CreateRandomTwoDemArray(6, 4, 1, 9);
ShowTwoDemArray(myArray);
FindMinSumRow(myArray);
*/

// Задача 62.
// Заполните спирально массив 4 на 4.

int[,] FillArraySpyral(int m, int startNum)
{
    m = 4;
    startNum = 1;
    int[,] matrix = new int[m, m];
    int number = startNum;
    
        for (int y = 0; y < m; y++)
        {
            matrix[0,y] = number;
            number++;
        }

        for (int x = 1; x < m; x++)
        {
            matrix[x, m-1] = number;
            number++;
        }

        for (int y = m - 2; y >= 0; y--)
        {
            matrix[m-1,y] = number;
            number++;
        }
        
        for (int x = m - 2; x > 0; x--)
        {
            matrix[x,0] = number;
            number++;
        }

        for (int y = 1; y < m - 1; y++)
        {
            matrix[1,y] = number;
            number++;
        }

        for (int y = m - 2; y >= 1; y--)
        {
            matrix[2,y] = number;
            number++;
        }
        

    
    return matrix;
}

int[,] myMatrix = FillArraySpyral(4, 1);
ShowTwoDemArray(myMatrix);