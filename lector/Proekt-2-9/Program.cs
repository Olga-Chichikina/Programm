
/*
// 1 вариант нахождения максимального числа
int a1 = 10;
int d1 = 1500;
int c1 = 30;
int a2 = 50;
int d2 = 50;
int c2 = 300;
int a3 = 17;
int d3 = 18;
int c3 = 9;

int max = a1;

if (d1>max) max=d1;
if (c1>max) max=c1;
if (a2>max) max=a2;
if (d2>max) max=d2;
if (c2>max) max=c2;
if (a3>max) max=a3;
if (d3>max) max=d3;
if (c3>max) max=c3;

Console.WriteLine(max);
*/

// 2 вариант нахождения максимального через метод(функцию)
int Max ( int arg1, int arg2, int arg3 )
{
  int result=arg1;
  if ( arg2 > result) result = arg2;
  if ( arg3 > result) result = arg3;
  return result;
} 
int a1 = 10;
int d1 = 1500;
int c1 = 30;
int a2 = 50;
int d2 = 50;
int c2 = 300;
int a3 = 17;
int d3 = 18;
int c3 = 9;

/*int max1 = Max ( a1, d1, c1) ;
Console.WriteLine(max1);
int max2 = Max ( a2, d2, c2) ;
Console.WriteLine(max2);
int max3 = Max ( a3, d3, c3) ;
Console.WriteLine(max3);

int max = Max ( max1, max2, max3) ;
Console.WriteLine("Максимальное число равно");
Console.WriteLine(max);
*/
// функциональное програмиирование
int max = Max ( Max ( a1, d1, c1), Max ( a2, d2, c2),Max ( a3, d3, c3)) ;
Console.WriteLine("Максимальное число равно");
Console.WriteLine(max);




