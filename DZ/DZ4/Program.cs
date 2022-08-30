//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Stepen ( int arg1, int arg2 )
{
int i =0;
int rez=1;
    while(  i< arg2 )
    {
    rez= arg1 * rez; 
    i++;
    }
    
return rez;
}
Console.WriteLine("Введите первое число а  ");
int a =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе  число b  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("число А в степени В равно  ");
int st=Stepen(a,b);
Console.Write(st);
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSumCifr ( int[] number , int cifr)  //  количество цифр в числе
{
    int sum =0;
    int i=0;
        while ( i <= number.Length)
         {
            sum=sum+number[i]; 
            i++;
         }
     return sum;
}

Console.Write(" Введите число : ");
int[] num=Console.ReadLine();
int summa=FindSumCifr (num);
Console.WriteLine("сумма цифр числа равна  " + summa);


/*

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/