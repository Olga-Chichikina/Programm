//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int FindSum ( int number)
{
    int sum =0;
    int count;
    count=1;
        while ( count <= number)
         {
            sum=sum+count; 
            count++;
         }
     return sum;
}

Console.Write(" Введите число : ");
int num=Convert.ToInt32(Console.ReadLine());
int summa=FindSum (num);
Console.WriteLine("summa is " + summa);




//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
void Metod ( int arg ) 
{
    int kolvocifr=arg.ToString().Length;
    Console.WriteLine(  kolvocifr);
}

Console.Write("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
Metod(number);
*/


//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Metod ( int arg ) 
{
    int proiz=1;
    int count=1;
    while ( count <= arg)
    {
        proiz=count *proiz;
        count++;
    }
    return proiz;
}

Console.Write("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int pro=Metod(number);
Console.WriteLine("Произведение" + pro);

*/


//Напишите программу, которая выводит массив из 8 элементов в случайном порядке




