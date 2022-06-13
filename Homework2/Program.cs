// Задача 3
/*
int SecondDigit()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine(number);
    int second_rank = number / 10;
    int result = second_rank % 10;
    return result;
}

Console.WriteLine(SecondDigit());
*/



// Задача 13
/*
string ThirdDigit()
{
    Console.WriteLine("Enter the integer number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num / 100 == 0) return "There is no third digit";
    else
    {
        string string_num = Convert.ToString(num);
        char result = string_num[2];
        return "The third number is : " + result;
    }
}
Console.WriteLine(ThirdDigit());
*/

// Та же задача через цикл, не срабатывает если больше трех цифр, не понимаю в чем ошибка
/*
string ThirdDigit()
{
    Console.WriteLine("Enter the integer number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num / 100 == 0) return "There is no third digit";
    else
    {
        if(num / 100 >= 1 || num / 100 <=9) return "Third digit is: " + num % 10;
        else
        {
            int current = num;
            while(current / 100 > 9)
            current /= 10;
            return "Third number is: " + current % 10;
        }
    }
}

Console.WriteLine(ThirdDigit());
*/

// Задача 15
/*
string DayOfWeek()
{
    Console.WriteLine("Enter the integer number from 1 to 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <=5) return "You have to work";
    else if(number == 6 | number == 7) return "It's  a day off";    
    else return "Wrong number, try again";
}

Console.WriteLine(DayOfWeek());
*/
