Console.WriteLine("Введите ваше число");
int n = Convert.ToInt32(Console.ReadLine());
if ( n > 100)
{
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Нет третьего числа");
}
