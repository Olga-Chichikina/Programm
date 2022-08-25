//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
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
*/

//напишите программу , которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
/*
void Metod (int arg)
{
int cot=arg /100;
int ed = arg % 10;
Console.WriteLine("При удалении второй цифры получится число: " + cot + ed );
}

int number=new Random().Next(100,999);
Console.WriteLine("Случайное число  " + number) ;
Metod(number);
*/

// Программа будет принимать на вход два числа и выводить является ли второе число кратным первому 

void Metod( double arg1, double arg2 )
{
double del=arg1/arg2;
if ( Convert.ToInt32(del)==Convert.ToDouble(del)) Console.WriteLine(" Второе число является кратным первому");
else Console.WriteLine("Второе число не кратное первому");
}
Console.Write("Введите первое число  " );
double number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число  ");
double number2=Convert.ToInt32(Console.ReadLine());
Metod(number1, number2);
