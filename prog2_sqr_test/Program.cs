// Проверка первое число квадрат второго
Console.Write("Введите число 1: ");
int  num1;
num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2;
num2=Convert.ToInt32(Console.ReadLine());
if(num1==num2*num2) {
    Console.WriteLine($"Первое число {num1} это квадрат второго {num2}");
}
else {
    Console.WriteLine($"Число {num1} не квадрат чила {num2}!");
}
