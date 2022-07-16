
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


// Задача 1: Задайте массив строк.
// Напишите программу, считает кол-во слов в массиве,
// начинающихся на гласную букву.

/*
int CountVowels(string[] array)
{
    int count = 0;
    char[] vowels = {'a', 'o', 'u', 'e', 'i', 'y'};
    
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
            if (array[i][0] == vowels[j]) count++;
    return count;
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myWords = CreateStringArray(size);

Console.WriteLine(CountVowels(myWords));
*/


//  Задайте массив строк.
// Напишите программу, которая генерирует новый массив,
// объединяя элементы исходного массива попарно.


string[] UniteByTwoElements(string[] array)
{
    int size = array.Length/2;
    if (array.Length % 2 != 0) size += 1;
    string[] united = new string[size];


    
        for (int i = 0; i < array.Length/2; i++)
            united[i] = array[i * 2] + array[i * 2 +1];

    if(array.Length % 2 !=0)
        united[array.Length/2] = array[array.Length-1];

    return united;

}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myWords = CreateStringArray(size);

string[] result = UniteByTwoElements(myWords);

ShowArray(result);


