/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(2, 4);

if (result == -1) Console.WriteLine("Данная точка находится на осях");
else Console.WriteLine ($"Точка находится в {result} четверти");
*/


/*
void Coordinates(int quart)
{
    if (quart == 1) Console.WriteLine("x > 0 and y > 0");
    if (quart == 2) Console.WriteLine("x > 0 and y < 0");
    if (quart == 3) Console.WriteLine("x < 0 and y < 0");
    if (quart == 4) Console.WriteLine("x < 0 and y > 0"); 

    Console.WriteLine("Wrong number");   
}

Console.WriteLine("Enter the number from 1 to 4: ");
int number = Convert.ToInt32(Console.ReadLine());
Coordinates(number);
*/


/*
void Square(int num)
{
    if (num < 0) num = num * -1;
    int current = 1;
    while (current <= num)
    {
        Console.Write(current * current + " ");
        current++;
    }
}

Console.WriteLine("Input integer number: ");
int any_num = Convert.ToInt32(Console.ReadLine());
Square(any_num);
*/

double FindLength(double xA, double yA, double xB, double yB)
{
   return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB - yA), 2));
}

