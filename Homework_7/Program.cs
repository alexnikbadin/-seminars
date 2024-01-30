//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void FromMtoN(int m, int n)
{
    if (m < n)
    {
        FromMtoN(m + 1, n);
        Console.Write(m + " ");
    }

}

Console.WriteLine("Input m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n:");
int n = Convert.ToInt32(Console.ReadLine());
FromMtoN(m, n);//не понял почему в обратном порядке

//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.WriteLine("Input m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n:");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m, n);

//Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

void RandomArray(char[] array)
{
    int i = array.Length - 1;
    if (array.Length > 0)
    {
        Console.Write(array[i] + " ");
        RandomArray(array.SkipLast(1).ToArray());

    }

}
char[] array = { 'h', 'e', 'l', 'l', 'o' };
RandomArray(array);


