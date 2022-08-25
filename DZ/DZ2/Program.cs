

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
void Metod (int arg )
{
int rezultat;
rezultat = arg / 10 % 10 ;
Console.WriteLine("Вторая цифра этого числа :  " + rezultat);
}

Console.Write("Введите любое трехзначное число:  ");
int number=Convert.ToInt32(Console.ReadLine());
Metod (number);
*/


//Задача 13: Напишите программу, которая выводит третью цифру с конца 
// заданного числа или сообщает, что третьей цифры нет.

// 1 вариант
void Metod (long arg )
{
if ( arg < 100 ) Console.WriteLine("Третьей цифры у этого числа  нет  " );
if (arg >=100 ) Console.WriteLine("Третья  цифра этого числа :  " + arg % 1000 / 100);
}
Console.Write("Введите любое  число в диапазоне от 0 до 1000000000 и программа определит третью цифру этого числа:  ");
long number=Convert.ToInt64(Console.ReadLine());
Metod (number);



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Metod (int arg )
{
if ( arg <=5 ) Console.WriteLine( arg + " - не выходной " );
if ( arg == 6 ) Console.WriteLine( arg + " - выходной " );
if ( arg == 7 ) Console.WriteLine( arg + " - выходной " );
}

Console.Write("Введите день недели , а мы определим выходной или нет :  ");
int number=Convert.ToInt32(Console.ReadLine());
Metod (number);
*/

