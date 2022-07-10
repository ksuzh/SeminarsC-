// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

/*
int SumOfNumbers(int m, int n)
{
    if (n == m) return m;
    return n + SumOfNumbers(m, n - 1);
}

Console.Write("Input integer  number: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer  number: ");
int N= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNumbers(M, N));
*/


// Задача 67:
// Напишите программу, которая будет принимать
// на вход число и возвращать кол-во его цифр.

int CountDigits(int num)
{
    int count = 1;
    if (num == 0) return 1;
    else return count + CountDigits(num/10);
}

Console.WriteLine("Input integer  number: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountDigits(M));


