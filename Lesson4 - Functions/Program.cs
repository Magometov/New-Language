/*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)

    2, 4 -> 16
*/


Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int numB = int.Parse(Console.ReadLine());

int GetDegreeNum(int number, int pow)
{
    int result = number;
    for(int i = 1; i < pow; i++)
    {
        result *= number;
    }
    return result;
}

Console.WriteLine($"{numA}, {numB} -> {GetDegreeNum(numA,numB)}");


/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11

    82 -> 10

    9012 -> 12
*/


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumDigit(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10; 
    }
    return sum;
}

Console.WriteLine($"{num} -> {GetSumDigit(num)}");


/*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

    6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("-------Задача № 29-------");
int[] Array = new int[8];

void Put (int [] Numbers)
{
  int length = Numbers.Length;
  
  for (int i = 0; i < length; i++)
  {
      Numbers[i] = new Random().Next(1, 10);
  }
  return;
}

void Print (int[] point)
{
  int digit = point.Length;
  for (int count = 0; count < digit; count++)
  {
      System.Console.Write(point[count] + " ");
  }
  return;
}

Put(Array);
Print (Array);

