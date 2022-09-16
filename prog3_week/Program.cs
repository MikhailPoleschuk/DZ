// Назавание дня по заданному номеру 
Console.Write("Введите день недели от 1 до 7:");
int num_day;
num_day = Convert.ToInt32(Console.ReadLine());
if (num_day>7 || num_day<1) 
{
    Console.Write("не верное число, введите число от 1 до 7 ");
}
else if (num_day==1) 
{
    Console.Write("ПН");
}
else if (num_day==2) 
{
    Console.Write("ВТ");
}
else if (num_day==3) 
{
    Console.Write("СР");
}
else if (num_day==4) 
{
    Console.Write("ЧТ");
}
else if (num_day==5) 
{
    Console.Write("ПТ");
}
else if (num_day==6) 
{
    Console.Write("СБ");
}
else if (num_day==7) 
{
    Console.Write("ВС");
}
