//Задача 1. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void division(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
division(number);

//Задача 2  Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

void findPlane(int x, int y)
{
    if (x > 0 & y > 0)
    {
        Console.WriteLine("Точка находится в 1 четверти");
    }
    else if (x > 0 & y < 0)
    {
        Console.WriteLine("Точка находится в 4 четверти");
    }
    else if (x < 0 & y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверти");
    }
    else if (x < 0 & y > 0)
    {
        Console.WriteLine("Точка находится в 2 четверти");
    }
    else
    {
        Console.WriteLine("Введите неотрицательное значение переменной");
    }

}
Console.WriteLine("Input num1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2");
int num2 = Convert.ToInt32(Console.ReadLine());
findPlane(num1, num2);

//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа

void findMax()
{
    int num = new Random().Next(10, 99 + 1);
    Console.WriteLine(num);
    int num1 = num / 10;
    int num2 = num % 10;
    if (num1 < num2)
    {
        Console.WriteLine(num2);
    }
    else if (num1 == num2)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        Console.WriteLine(num1);
    }
}
findMax();

//Задача 4  Напишите программу, которая на вход принимает натуральное 
//число N, а на выходе показывает его цифры через запятую.


void numbers(int num)
{
    string numForsplit = num.ToString();
    string[] result = numForsplit.Split(',');
    foreach (var x in result)
    {
        Console.WriteLine($" , {x} , ");
    }

}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
numbers(number);


