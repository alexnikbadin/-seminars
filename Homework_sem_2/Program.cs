﻿/*// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

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
division(number);*/

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


