Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
if( b/100 >0)
{
    while ( b >= 1000)
    {
        b = b /10;
    }
    Console.WriteLine( b % 10);
}
else
{
    Console.WriteLine("нет третьего числа");
}