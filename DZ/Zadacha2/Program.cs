// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите первое число: ");
double numA;
numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Второе число: ");
double numB;
numB = Convert.ToDouble(Console.ReadLine());
if (numA==numB) {
    Console.Write($"Оба числа равны {numB}");
}
else if (numA>numB) {
    Console.Write($"Первое число {numA} больше чем второе {numB}");
}
else {
    Console.Write($"Второе число {numB} больше чем первое {numA}");
}

