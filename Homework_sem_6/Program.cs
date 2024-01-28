//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string str(char[,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str += matrix[i, j];
        }
    }
    return str;
}

char[,] CreateMatrix(int rows, int columns, int min, int max)
{
    char[,] matrix = new char[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToChar(rnd.Next());
        }

    }
    return matrix;
}
char[,] result = CreateMatrix(5, 5, 1, 100);


Console.WriteLine(str(result));

//2. Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnjpqrstuvwxyz";

void BigToSmall(string str)
{
    Console.WriteLine(str.ToLower());
}
BigToSmall(str1);


//3. Задайте произвольную строку. Выясните, является ли она палиндромом.

string StringToArray(string str)//метод разворота строки
{
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

Console.WriteLine("Input the string");
string str = Console.ReadLine();
string rev_s = StringToArray(str);

void IsEqual(string str)
{

    if (str == rev_s)
    {
        Console.WriteLine("Palindom");
    }
    else
    {
        Console.WriteLine("Not Palindom");
    }

}

IsEqual(str);

//4. Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

void FindSplit(string str)//проверяем есть ли в строке пробел
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str.IndexOf(' ') > -1)
        {
            continue;
        }
        else
        {
            Console.WriteLine("Input the split between words");
        }
    }
}
Console.WriteLine("Input the string with the split between words");
string str1 = Console.ReadLine();
FindSplit(str1);

string[] Reverse_string(string str1)
{
    string[] words = str1.Split(' ');//метод разделения строки и превращения строки в массив строк
    Array.Reverse(words);//разворачиваем массив строк
    string.Join(" ", words);
    return words;
}

void PrintResult(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
PrintResult(Reverse_string(str1));