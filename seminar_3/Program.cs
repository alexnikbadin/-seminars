/*// задать массив  понять если число в массиве выдать ответ да или нет

int[] randomArray(int size, int min, int max)// метод создания рандомного массива
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;


}
randomArray(10, 0, 10);

void printArray(int[] array)// метод вывода массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

int[] changeTonegative(int[] array)//метод замены эл массива на отрицательные
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

bool checkNum(int[] array, int num)// метод проверяющий наличие элемента в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

//Создать массив произведений эл-в заданного массива

int[] pairsCount(int[] array)
{
    int[] tempArray = (new int[array.Length / 2]);//задали массив для хранения произведений
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempArray[i] = array[i] * array[array.Length - i - 1];//умножаем через цикл крайние элементы массива двигаясь к центру
    }
    return tempArray;
}


Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = randomArray(size, min, max);
printArray(array);

Console.WriteLine("Input el");
int el = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(checkNum(array, el));

int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
int CountEvenItems(int[] numbers)
{
    int[] array = new int[10];
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter = counter + 1;
        }
    }
    return counter;
}

CountEvenItems(array);*/

double FindMin(double[] numbers)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
double FindMax(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
double[] array1 = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };

double result = FindMax(array1) - FindMin(array1);
void PrintResult(double[] array)
{
    Console.WriteLine(result);
}
PrintResult(array1);