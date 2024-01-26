// Найти значение факториала рекурсией

/*int Fact(int n)
{
    if (n == 1)
    {
        return 1;
    }
    return n * Fact(n - 1);
}
Console.WriteLine(Fact(5));

//задать массив символов и сделать из него строку

using System.Runtime.InteropServices;

string charsTostring(char[] chars)
{
    string str = ""; //создаем пустую строку
    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];//через цикл прибавляем к пустой строке каждый эл-т массива
    }
    return str;
}

char[] chars = new[] { 'a', 'b', 'c', 'd' };
Console.WriteLine(charsTostring(chars));

//задать строку и написать метод формирования массива символов из строки

char[] StringToChar(string str)
{
    char[] Ch = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        Ch[i] = str[i];// через цикл еняем эл-т строки на эл-т массива и заносим его в массив
    }
    return Ch;

}

void PrintChar(char[] chars)
{
    for (int i = 0; i < chars.Length; i++)
    {
        Console.Write(chars[i] + ",");
    }
}
string str = "Hello";
//Console.WriteLine(StringToChar(str));
PrintChar(StringToChar(str))*/

//Считать строку с консоли состоящую из латинских букв и выяснить сколько в этой строке гласных

int Vowels(string str)
{
    char[] Ch = { 'a', 'e', 'i', 'o', 'u' };
    int num = 0;
    for (int i = 0; i < str.Length; i++)
    {
        foreach (char el in Ch)
        {
            if (el == str[i])
            {
                num++;
            }
        }
    }
    return num;
}

Console.WriteLine("Input str:");
string str = Console.ReadLine();
Console.WriteLine(Vowels(str));

