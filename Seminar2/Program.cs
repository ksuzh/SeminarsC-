// 5 % 2 -> 1
// 5 / 2 -> 2

// 1234 / 10 -> 123 % 10 -> 3
// 1234 % 10 -> 4
// 1234 % 100 -> 34
// 1234 / 100 -> 12

// a /= 10 <-> a = a / 10

/*
int FindMaxPart(int num)
{
    int dec, ed;

    if(num >= 10 && num <= 99)
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not two-digit");
}
else
{
    Console.WriteLine($"Bigger digit of {a} is {result}");
}
*/


/*
int NoSecondDigit()
{
    int number = new Random().Next(100, 1000);
    int first_rank = number / 100;
    int third_rank = number % 10;
    int result = first_rank + third_rank;
    return result;
}
*/

/*
string IfAliquot(int number1, int number2)
{
    if(number2 % number1 == 0) return "Aliquot";
  
    else return ("Not aliquot, remainder is " +  number2 % number1);
}
*/

/*
int AliquotCheck(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = AliquotCheck(num);
if(result == 1)
{
    Console.WriteLine("Aliquot");
}
else
{
    Console.WriteLine("It's not aliquot");
}
*/


// тоже третья задача, булево
/*
bool AliquotCheck(int num)
{
    if (num % 23*7 == 0) return true;
    else return false;
    
    // return (num % 23*7 == 0);
}
*/



