// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите Первое число: ");
double num1;
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Второе число: ");
double num2;
num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Третье число: ");
double num3;
num3 = Convert.ToDouble(Console.ReadLine());
if (num1>num2 & num1>num3)
{
    Console.Write($"Самое большое число {num1}");
}
else if (num2>num1 & num1>num3)
{
    Console.Write($"Самое большое число {num2}");
}
else
{
    Console.Write($"Самое большое число {num3}");
}
