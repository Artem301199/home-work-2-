//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\
//n/10 n%100
Console.WriteLine("ВВедите число ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n / 100 >0)
{
    while (n >= 1000)
    {
        n = n / 10;
    }
    Console.WriteLine(n %10 );

}
else
{
    Console.WriteLine("Третьего числа нет");
}

