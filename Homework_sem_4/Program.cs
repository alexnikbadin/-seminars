//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

/*int[] randomArray(int size, int min, int max)// метод создания рандомного массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
Console.WriteLine(randomArray(10, 100, 999));

int CountEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

Console.WriteLine(CountEven(randomArray(10, 100, 999)));*/

//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

int[] randomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] ReverseArray(int[] array)
{
    int n = array.Length;
    int[] rev_array = new int[n];

    for (int i = 0; i < n; i++)
    {
        rev_array[n - 1 - i] = array[i];
    }

    for (int i = 0; i < n; i++)
    {
        array[i] = rev_array[i];
    }
    return rev_array;

}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
int[] result = randomArray(10, 0, 100);
printArray(result);

printArray(ReverseArray(result));


