/*
int num1, num2;

Console.WriteLine("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max is: " + num1);
}
else
{
    Console.WriteLine("max is: " + num2);
}
*/

/*
int num1, num2, num3;

Console.WriteLine("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.Write("Max number is: " + max);
*/

/*
Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
Console.WriteLine("The number is even");
}
else
{
    Console.WriteLine("The number isn't even");
}
*/

int num, current;

Console.WriteLine("Enter the number: ");
num = Convert.ToInt32(Console.ReadLine());

current = 2;
while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}


