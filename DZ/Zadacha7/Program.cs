// Трехзначное число, вывести последнюю цифру
Console.Write("Введите 3х значное число:");
int N=Convert.ToInt32(Console.ReadLine());
if (N<100 || N >999) 
{
    Console.Write("Вы ввели не трехзначное число, пожалуйста, попробуйте заного :)");
}
else 
{
while (N > 100) N=N-100;
while (N>10) N=N-10;
Console.WriteLine($"Последняя цифра это {N}");
}
