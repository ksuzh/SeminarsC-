 
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

/*
int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum+=array[i]; // sum = sum + array[i]
    }

    return sum;
}
*/

/*
int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum+=array[i]; // sum = sum + array[i]
    }

    return sum;
}

int[] myArray = CreateRandomArray(12, -9, 9);

Console.WriteLine("Sum of positive numbers is: " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is: " + FindNegativeSum(myArray));
*/

/*
int[] ChangePositiveNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
    
}

int[] myArray = CreateRandomArray(12, -10, 10);

Console.WriteLine(ChangePositiveNegative(myArray));
*/


bool CheckNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

int[] myArray = CreateRandomArray(12, 10, 100);
Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckNumber(myArray, number));



/*
int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(12, 1, 200);

Console.WriteLine("The amount of numbers between 10 and 99 is: " + CountNumbers(myArray));
*/


