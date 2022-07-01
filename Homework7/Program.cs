// Создание массива и его вывод для задач 50 и 52
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


// Задача 47

/*
double[,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * ((max - min) + min), 1);
    return matrix;
}


void ShowTwoDemArray(double[,] array)
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
*/




// Задача 50
/*
void ReturnElementByIndex(int[,] array, int num1, int num2)
{
    if (num1 < 0 || num1 >= array.GetLength(0) || num2 < 0 || num2 >= array.GetLength(1)) Console.WriteLine("The element doesnt exist");
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if ( i == num1 && j == num2) Console.WriteLine($" The element is {array[i,j]}");
}


// Задача 52

void ColumnAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        double average = sum / array.GetLength(0);
        Console.WriteLine($"The arithmetic of the {j} column is {average}");
       
    }
    
}


// Вывод для задачи 47
/*
Console.WriteLine("Input amount of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input amount of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myMatrix = CreateRandomTwoDemArray(m, n, min, max);
ShowTwoDemArray(myMatrix);
*/


// Вывод для задачи 50
/*
int[,] myMatrix = CreateRandomTwoDemArray(5, 6, -9, 9);
ShowTwoDemArray(myMatrix);

Console.WriteLine("Input first index: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second index: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

ReturnElementByIndex(myMatrix, m, n);
*/



// Вывод для задачи 52
/*
int[,] myMatrix = CreateRandomTwoDemArray(5, 6, 0, 9);
ShowTwoDemArray(myMatrix);
Console.WriteLine();

ColumnAverage(myMatrix);
*/