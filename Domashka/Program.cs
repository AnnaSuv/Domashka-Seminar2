/*
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.*/


System.Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 ==0 && num % 23 == 0)
{
System.Console.WriteLine($"Число {num} кратно и 7 и 23 одновременно");
}
else
{
    System.Console.WriteLine($"Число {num}не кратно одновременно 7 и 23");
}

/*Напишите программу, которая принимает на вход
координаты точки (Х и У), причём Х не=0 и У не=0 
и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка. */


System.Console.WriteLine("Введите два числа   ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Одна из координат равна нулю, невозможно определить координатную четверть");
    return;
}

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Координатная четверть первая");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Координатная четверть вторая");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Координатная четверть третья");
}
else
{
    System.Console.WriteLine("Координатная четверть четвёртая");
}


/* Напишите программу, которая принимает на вход 
целое число из отрезка [10,99] и показывает наибольшую
цифру числа*/


System.Console.WriteLine("Введите число в промежутке от 10 до 99  ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int number2 = number % 10;

if (number < 10 || number > 99)
{
    System.Console.WriteLine("Число не находится в промежутке от 10 до 99");
    return;
}
if (number1 = number2)
{
    System.Console.WriteLine($"Цифры числа {number} равны {number1}");
}
else (number1 > number2);
{
    System.Console.WriteLine($"Наибольшая цифра числа {number} равна {number1}");
}
System.Console.WriteLine($"Наибольшая цифра числа {number} равна {number2}");


/* Напишите программу, которая на вход принимает натуральное число N, а 
на выходе показывает его цифры через запятую*/

System.Console.WriteLine("Введите любое натуральное число  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    System.Console.WriteLine("Введено ненатуральное число");
    return;
}
while (N > 0)
{
    int currentDight = N % 10;
    N /= 10;
    if (N > 0)
    {
        System.Console.WriteLine(currentDight + ",");
    }
    else
    {
        System.Console.WriteLine(currentDight);
    }
}