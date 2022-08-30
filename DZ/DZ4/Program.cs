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
/*

Console.Write(" Введите число : ");
int num= Convert.ToInt32(Console.ReadLine());
 
int summa=0;
    while( num !=0 )
    {   
    summa=summa+num%10;
    num= num/10;
    }   

Console.WriteLine("сумма цифр числа равна  " + summa);
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


/*
Console.Write ("Введите количество элементов массива :");
int elementCount=Convert.ToInt32(Console.ReadLine());
int[] myArray= new int[elementCount];
    for( int i=0 ; i < myArray.Length ; i++)
    {
    Console.Write($"Введите  элемент массива с индексом {i}  ")  ;
    myArray[i]=Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Ввывод массива на экран");
    for( int i=0 ; i< myArray.Length; i++)
    {
        Console.Write(myArray[i]+" , " );
    }
*/