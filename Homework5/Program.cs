
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

// Задача 34

int AmountEvenDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] myArray =  CreateRandomArray(20, 100, 1000);
Console.WriteLine(AmountEvenDigits(myArray));


// Задача 36
/*
int SumNotEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2) sum += array[i];
    return sum;
}
int[] myArray =  CreateRandomArray(10, -10, 10);
Console.WriteLine(SumNotEvenIndex(myArray));
*/

// Задача 38
/*
double[] CreateRandomDoubleArray(int size, double min, double max)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i ++)
    {
        newArray[i] = Math.Round(new Random().NextDouble() * ((max - min) + min), 3);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}


double[] myArray = CreateRandomDoubleArray(10, 0, 50);

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] < min) min = array[i];
       if (array[i] > max) max = array[i];
    } 
    double diff = max - min;
    return diff;
}

Console.WriteLine(DiffMaxMin(myArray));
*/
