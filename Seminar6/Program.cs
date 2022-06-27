/*
int[] ReverseArrayWhile(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0;

    while(i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    return array;
}



int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1;

    for(int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}


int[] myArray = {2, 4, 6, 8, 10};

myArray = ReverseArrayWhile(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/

/*
bool TriangleCheck(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    else return false;
}

Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input C: ");
int C = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TriangleCheck(A, B, C));
*/

/*
int[] Fibonacci(int n)
{
    
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");

    for (int i = 2; i < n; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write(array[i] + " ");
    }
    return array;
     
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Fibonacci(num));
*/
string DecimalToBinary(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result; 
        num = num / 2; // num /=2;  
    }
    return result;
}

Console.WriteLine(DecimalToBinary(8));
