// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

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
