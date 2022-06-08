/*

int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

num = num * num;

Console.WriteLine("Result is: " + num);
*/


/*
int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
  Console.WriteLine("True");  
}
else
{
    Console.WriteLine("False");
}
*/

int num;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; // current = current + 1;
}






