/*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1
*/


Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());


if ((num > 99) && (num < 1000))
{
    int result_num = (num / 10) % 10;
    Console.WriteLine($"{num} -> {result_num}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}



/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    645 -> 5

    78 -> третьей цифры нет

    32679 -> 6
*/


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int first_num = num;

if(num <= 99)
{
    Console.WriteLine($"{first_num} -> третьей цифры нет");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }

    Console.WriteLine($"{first_num} -> {num % 10}");
}


/*
    Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет
*/


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 8)
{
    Console.WriteLine("Нет такого дня недели!");
}
else
{
    if (num == 6 | num ==7)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
}
