// Задача 41
/*
int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Input numbers, use space to split: ");
int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Console.WriteLine(CountPositive(numbers));
*/

// Задача 45

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

int[] myArray = CreateRandomArray(10, 0, 20);

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
        Console.Write(copy[i] + " ");
    }
    Console.WriteLine();
    return copy;
}

Console.WriteLine(CopyArray(myArray));
