
//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
/*
Console.Write("Input number: ");
int number=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("My number is = " + number) ;

int kvadrat=number*number;

Console.WriteLine("Kvadrat number  is=" +kvadrat );

Console.WriteLine("Good moning!");
//пример цикла
int current = 0 ;
while (current < 10 )
{
Console.WriteLine(current);
current ++;
} 
*/


//Задача1 . Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
/*
Console.Write("Input number1: ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int number2=Convert.ToInt32(Console.ReadLine());
int kvadrat= number2*number2;

if (number1 == kvadrat )
{
   Console.Write("Первое число является квадратом второго");
}
 else
{
   Console.Write("Первое число  не  является квадратом второго"); 
}
*/

//Задача 2 Напишите программу, которая на вход принимает одно число (N), а на выходе 
//показывает все целые числа в промежутке от -N до N.

Console.Write("Input number: ");
int number=Convert.ToInt32(Console.ReadLine());
int current = (-1)*number ;
while (current < number+1 )
{
Console.WriteLine(current);
current ++;
} 

