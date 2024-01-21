//задайте одномерный массив, заполненный случайными числами. Определить количество простых 
//чисел в массиве

int[] randomArray(int size, int min, int max)// метод создания рандомного массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;

}

void printArray(int[] array)// метод вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SimpleNumCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 1 && array[i] % 2 != 0 || array[i] == 2)
            if (array[i] % 3 != 0 || array[i] == 3)
                if (array[i] % 5 != 0 || array[i] == 5)
                    if (array[i] % 7 != 0 || array[i] == 7)
                    {
                        counter = counter + 1;
                    }



    }
    return counter;
}

int NumCounter(int[] array) // метод подсчета чисел которые заканчиваются на 1 и делятся на 7
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 && array[i] % 7 == 0)
        {
            counter++;
        }

    }
    return counter;
}

int[] ArrayToNum(int[] array) // метод создающий число из массива(склеиваем строку и конвертируем в число)
{
    string str = string.Empty;// создаем пустую строку
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];

    }
    return Convert.ToInt32(str);
}


Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = randomArray(size, min, max);
printArray(array);
Console.WriteLine(SimpleNumCounter(array));



