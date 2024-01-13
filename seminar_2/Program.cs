/* Делаем метод (функции) по типу данных void

void numToquad(int num)
{
    Console.WriteLine(num * num);
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
numToquad(number);

// Делаем метод (функцию) по типу данных int

int numToquad2(int num)
{
    return num * num;
}

Console.WriteLine("Input number");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = numToquad2(number2); //чтобы результат метода на экран нужно определить переменную с результатом
Console.WriteLine(numToquad2(number2));//или сразу передаем в вывод*/

//Задача 1  Напишите программу которая принимает на вход трехзначное число и удаляет из него второе число


/*void delDtgit(int num)
{
    if (num >= 100 && num <= 999)
    {
        Console.WriteLine($"{num} -> {num / 100 * 10 + num % 10}");
    }
    else
    {
        Console.WriteLine("Wrong num");
    }
}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
delDtgit(number);*/



//3.Ввести трехзначное число и и возвести 2 цифру в степень третьей

/*int secTothird(int num)
{
    if (num >= 100 && num <= 999)
    {
        int thirdDig = num % 10;
        int secDig = num / 10 % 10;
        return (int)Math.Pow(thirdDig, secDig);//используется встроенный метод Pow для возведения в степень
    }
    return 0;

}
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
secTothird(number);*/

//Задача 3. 







