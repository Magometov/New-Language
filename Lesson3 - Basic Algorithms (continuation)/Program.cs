/*
    Задача 19

    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет

    12821 -> да

    23432 -> да
*/



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int some_num = num;
int result_num = 0;

while(num > 0)
{
    int last_digit = num % 10;
    result_num = result_num * 10 + last_digit;
    num = num / 10;
}
if(result_num == some_num)
{
    Console.WriteLine($"{some_num} -> да");
}
else
{
    Console.WriteLine($"{some_num} -> нет");
}



/*
    Задача 21

    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    A (3,6,8); B (2,1,-7), -> 15.84

    A (7,-5, 0); B (1,-1,9) -> 11.53
*/



Console.Write("Введите координаты первой точки: ");
string [] numA = Console.ReadLine().Split(' ');

int x1 = Convert.ToInt32(numA[0]);
int y1 = Convert.ToInt32(numA[1]);
int z1 = Convert.ToInt32(numA[2]);


Console.Write("Введите координаты второй точки: ");
string [] numB = Console.ReadLine().Split(' ');

int x2 = Convert.ToInt32(numB[0]);
int y2 = Convert.ToInt32(numB[1]);
int z2 = Convert.ToInt32(numB[2]);


int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {Math.Round(Math.Sqrt(A * A + B * B + C * C), 2)}");



/*
    Задача 23

    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/



int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}



// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}