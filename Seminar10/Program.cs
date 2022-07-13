// string[] names = {"Ivan", "Anna", "Max", "Denis"};

// Console.WriteLine(names[0][1]);

// Написать метод, который на вход берет массив строк,
// а на выходе возвращает количество слов, длина которых больше 5.

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i +1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}


void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


/*
int NumberOfLongWords(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i].Length >= 5)
            count++;

    return count;
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/


//  Написать программу, которая принимает на вход
// два массива строк и возвращает массив из
// попарно объединенных исходных элементов.

/*
string[] UniteArrays(string[] array1, string[] array2)
{
    int size;
    if (array1.Length > array2.Length)
        size = array1.Length;
    else 
        size= array2.Length;

    string[] arrayUnited = new string[size];
    for (int i = 0; i < size; i++)
        arrayUnited[i] = array1[i] + " " + array2[i];

    return arrayUnited;
}

string[] firstArray = {"Hello", "hi", "hi there", "sup", "hey"};
string[] names = {"Ivan", "Anna", "Max", "Denis", "Alex"};

string[] hiArray = UniteArrays(firstArray, names);

ShowArray(hiArray);
*/

string[] UniteArrays(string[] array1, string[] array2)
{
    if (array1.Length > array2.Length)
    {
        for (int i = 0; i < array2.Length; i++)
            array1[i] = array1[i] + array2[i];
        return array1;
    }

    else
        for (int i = 0; i < array1.Length; i++)
            array2[i] = array2[i] + array1[i];
        return array2;
}

string[] firstArray = {"Hello", "hi", "hi there", "sup", "hey"};
string[] names = {"Ivan", "Anna", "Max", "Denis"};

string[] hiArray = UniteArrays(firstArray, names);

ShowArray(hiArray);



// Написать программу, которая считает кол-во слов,
// начинающихся на букву Y или W.

/*
int CountWYWords(string[] array, char a, char b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i][0] == a || array[i][0] == b) count++;
    }
    return count;
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the first symbol: ");
char a = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Input the second symbol: ");
char b = Convert.ToChar(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine(CountWYWords(names, a, b));

Console.WriteLine(names[1].ToLower());
*/