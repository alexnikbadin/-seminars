//создать метод создания ДМ и найти эл-ты у которых оба индеса четные и возвести эти елементы в квадрат

int[,] CreateMatrix(int rows, int columns, int min, int max)//ряды столбцы мин значение массива и макс значение массива
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }

    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }
}

void FindEvenIndexes(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }

    }
}

//метод создания одномерного массива каждый элемент которого является средним арифметическим строк двумерного массива

double [,]AverageMatrix (int[,] matrix)
{
    double sum = 0;
    double [] srarray = new double[matrix.GetLength(0)]
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        srarray[i] = sum / matrix.GetLength(1);

    }
    return srarray;   
}



int[,] array = CreateMatrix(5, 5, 0, 100);
printMatrix((array));
FindEvenIndexes(array);
Console.WriteLine();
printMatrix(array);

