// Число на вход N. Выход массив из целых чисел от -N до N
int N;
Console.Write("Введите число N: ");
N=Convert.ToInt32(Console.ReadLine());
int ind=0;
int l = N*2+1;
int NI = -N;

//Console.Write($"Число NI = {NI}, длинна массива равна {l} ");

while (ind<l )
{
    Console.Write($" {NI} ");
    NI += 1;
    ind += 1;
}
Console.WriteLine($" вот такой массив, спасибо");
