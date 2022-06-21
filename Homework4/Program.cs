// Задача 25
/*
double Exponentiation(int num1, int num2)
{
    return Math.Pow(num1, num2);
}

Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Exponentiation(A, B));
*/

// Задача 25 через цикл
string ExponentiationWhile(int num1, int num2)
{
    int i = 2;
    int expo = num1;
    while (i <= num2)
    {
        expo = expo * num1;
        i++;
    }
    return $"The exponentiation is: {expo}.";
        
}

Console.WriteLine("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0) Console.WriteLine($"It's always 1.");
if (B == 1) Console.WriteLine($"It's {A}");
if (A == 0) Console.WriteLine("It cant be zero");

Console.WriteLine(ExponentiationWhile(A, B));


// Задача 29

/*
int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 50);
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
*/
