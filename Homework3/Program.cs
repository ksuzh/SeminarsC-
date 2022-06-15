// Задача 19
/*
void CheckPalindrome(int num)
{
    string string_num = Convert.ToString(num);
    if (string_num.Length > 5) Console.WriteLine("There have to be five digits");
    else
    {
        if (string_num[0] == string_num[4])
            {
                if (string_num[1] == string_num[3]) Console.WriteLine("The number is palindrome");
                else Console.WriteLine("Not palindrome");
            }
            else Console.WriteLine("Definately not"); 
    }       
}

Console.WriteLine("Input five digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckPalindrome(number);
*/

// Задача 21
/*
double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
}

Console.WriteLine(FindLength(3, 6, 8, 2, 1, -7));
*/


// Задача 23
void CubeRow(int num)
{
    if (num < 0) num = num * (-1);
   
    int current = 1;
    while (current <= num)
    {
        Console.Write(Math.Pow(current, 3) + " ");
        current++;
    }
    
}

Console.WriteLine("Input integer number: ");
int any_num = Convert.ToInt32(Console.ReadLine());
CubeRow(any_num);