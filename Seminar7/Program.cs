

int[,] CreateRandomDemArray(int rows, int col, int min, int max)
{
    int[,] newMatrix = new int[rows, col];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < col; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}


int[,] array = CreateRandomDemArray(5,5,1,10);
Console.WriteLine();

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


// Задача 1
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j. 
// Выведите полученный массив на экран.
/*
int[,] CreateDemArray(int rows, int col)
{
    int[,] Matrix = new int[rows, col];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < col; j++)
            Matrix[i, j] = i + j;
    return Matrix;
}


Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateDemArray(m, n);
*/



// Задача 2
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
/*
int[,] BothIndexesEven(int[,] matrix)
{
    int step = 2;
    for (int i = 0; i < matrix.GetLength(0); i+=step)
        for(int j = 0; j < matrix.GetLength(1); j+=step)
            matrix[i, j] *= matrix [i, j];
    return matrix;
}

int[,] myMatrix = BothIndexesEven(array);
ShowTwoDemArray(myMatrix);
*/

// Задача 3 
//Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.

int MainDiagonalSum(int[,] myMatrix)
{
    int sum = 0;   
    for (int i = 0; i < myMatrix.GetLength(0); i++)
            sum += myMatrix[i, i]; 
    return sum;
}

Console.WriteLine(MainDiagonalSum(array));
