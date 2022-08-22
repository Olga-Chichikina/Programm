//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggerDigit( int number)
{
int ed = number % 10;
int dec= number / 10;
int max;
if ( ed >dec)  max=ed;
else max = dec;
return max;
}

int randNumber= new Random().Next(10,100);
int biggerdigit= FindBiggerDigit(randNumber);
Console.WriteLine( randNumber);
Console.WriteLine( biggerdigit);



