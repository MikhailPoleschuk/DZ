﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num1;
Console.Write("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());

// вычислим целиком ли число делится на 2
int x = num1 / 2;     //разделим на 2 при том что используем целые числа
int y = x*2 ;         // получим назад число умножив его на 2
int z = num1 - y;     // вычтем результат от изначального числа

if (z == 1) // если z получился 1 значит число нечетное
{
    Console.Write("нечетное");
}
else {
    Console.Write("четное");
}
