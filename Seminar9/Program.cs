// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.

/*
void ShowNums(int n)
{
    if(n != 1)
        ShowNums(n - 1);
    Console.Write(n + " ");
}

Console.Write("Input integer positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

// Задайте значения M и N.
// Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

/*
void ShowNumbers(int n, int m)
{
    if (n != m)
        ShowNumbers(n - 1, m);
    Console.Write(n + " ");
}

Console.Write("Input integer positive number: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Input smaller integer positive number: ");
int M = Convert.ToInt32(Console.ReadLine());

ShowNumbers(N, M);
*/


// Напишите программу,
// которая будет принимать на вход число
// и возвращать сумму его цифр.

/*
int SumOfDigits(int num)
{   
    if (num == 0)
        return 0;
    return num%10 + SumOfDigits(num/10);
}

Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(number));
*/


// Напишите программу,
// которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

double Exponentiation(int num1, int num2)
{
    
    if (num2 > 0) return num1 * Exponentiation(num1, num2 - 1);
    else 
    {
        if (num2 < 0) return 1 / (num1 * Exponentiation(num1, -num2 - 1));
        else return 1;
    }
      
    
}

Console.Write("Input integer number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Exponentiation(number1, number2));

