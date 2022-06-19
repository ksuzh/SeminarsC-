/*
int FindSumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10; //sum += num % 10; - то же самое
        num = num / 10;  // num /= 10;
    }

    return sum;
}

int n = 234;
int result = FindSumOfDigits(n);
Console.WriteLine($"Сумма цифр в числе {n} равна {result}.");
*/

/*
string SumMult(int num)
{
    int sum = 1;
    int mult = 1;
    int i = 2;
    while (i <= num)
    {
        sum = sum + i;
        mult = mult * i;
        i++;
    }
    return $"sum is {sum} and mult is {mult}.";
    

}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumMult(number));
*/

/*
int Amount(int num)
{
    string string_num = Convert.ToString(num);
    int length = string_num.Length;
    return length;
}

Console.WriteLine("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Amount(number));
*/

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 2);
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}

