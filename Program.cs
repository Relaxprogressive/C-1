//Задача 1
Console.WriteLine("Задача 1");
Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 > number1) {
    Console.WriteLine ($"Число {number1} меньше числа {number2} ");}
    else {
    Console.WriteLine ($"Число {number1} больше числа {number2} ");}

//Задача 2
Console.WriteLine("Задача 2");
Console.WriteLine("Введи первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи третье число: ");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}    

Console.WriteLine ($"Максимальное число = {max}");

//Задача 3
Console.WriteLine("Задача 3");
Console.WriteLine("Введи число: ");
int X = int.Parse(Console.ReadLine()!);

if (X%2==0)
{
    Console.WriteLine ("Число четное");
}
else
{
    Console.WriteLine ("Число нечетное");
}

//Задача 4
Console.WriteLine("Задача 4");
Console.WriteLine("Введи N: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <=N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
    i++;
}