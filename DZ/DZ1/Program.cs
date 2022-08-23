

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* 1 вариант

Console.Write("Введите первое число:  ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2=Convert.ToInt32(Console.ReadLine());

if  ( number1 > number2 ) 
{ 
    Console.WriteLine("Первое число  " + number1 + " больше  " + number2);
}   
  else  
{
     if ( number1 == number2 )
    {
    Console.WriteLine( "Первое число  " + number1 + " равно второму числу " + number2);
    }  
    else
    {
        Console.WriteLine("Второе число  " + number2 + " больше первого " + number1 );
    }
}
*/
/* 2 вариант - с помощью метода

void Metod(int arg1, int arg2)
{
if  ( arg1 > arg2 ) 
{ 
    Console.WriteLine("Первое число  " + arg1 + " больше  " + arg2);
}   
  else  
{
     if ( arg1 == arg2 )
    {
    Console.WriteLine( "Первое число  " + arg1 + " равно второму числу " + arg2);
    }  
    else
    {
        Console.WriteLine("Второе число  " + arg2 + " больше первого " + arg1 );
    }
}
}

Console.Write("Введите первое число:  ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2=Convert.ToInt32(Console.ReadLine());
Metod (number1, number2 );
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
int Metod(int arg1, int arg2, int arg3) 
{
int result=arg1;
if ( arg2 > result ) result=arg2;
if ( arg3 > result ) result=arg3;
return result;
}

Console.Write("Введите первое число:  ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:  ");
int number3=Convert.ToInt32(Console.ReadLine());
int max=Metod (number1, number2, number3) ;
Console.WriteLine("Максимальное число :  " + max);
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
//число чётным (делится ли оно на два без остатка).

void Metod(int arg)
{
if ( arg % 2 == 0 )
{
    Console.Write(" Число четное ");
} 
else
{
   Console.Write("Число нечетное"); 
}
}

Console.Write("Введите число:  ");
int number=Convert.ToInt32(Console.ReadLine());
Metod(number);
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

void Metod( int arg)
{
    int count=0;
    while (count < arg+1 )
    {
    if (count % 2 == 0 )
    {
     Console.Write("  " + count + " , ");
    }
    count++;
    }
}

Console.Write("Введите число:  ");
int number=Convert.ToInt32(Console.ReadLine());
Metod(number);
