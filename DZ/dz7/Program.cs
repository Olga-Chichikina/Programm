//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


double[,] NewArrayD()   // создание массива , заполненного случайными числами
    {
        Console.WriteLine("Введите количество строк row");
        int row= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов colomn");
        int colomn= Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите минимальный элемент массива ");
        //double minValue= Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите максимальный элемент массива");
       // double maxValue= Convert.ToInt32(Console.ReadLine());
        double[,] massivD= new double[row,colomn];
            for( int i=0 ; i< row ; i++ )
                {
                    for(int j=0; j< colomn ; j++ ) 
                    massivD[i,j]= new Random().NextDouble()*10;
                   
                }
            return massivD;
    } 

void ShowArrayD(double[,] array) // метод вывода массива на экран
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i,j]} ");
            }
        Console.WriteLine();
        }
 }
double[,] newArrayDob=NewArrayD();
//Math.Round(newArrayDob,1);
ShowArrayD(newArrayDob);




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] GreatRandomZdArray()
 {
    Console.WriteLine("Введите rowse  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите colums  ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максим  величину массива  ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальную  величину массива  ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows,colums];
    for( int i=0 ; i< rows ; i++)
    {
        for(int j=0 ; j< colums ; j++)
        {
            newArray[i,j]= new Random().Next( minvalue, maxvalue+1);
        }
    } 
    return newArray;
 }

void Show2Array (int[,] array)
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i, j]} ");
            }
        Console.WriteLine();
        }
 }
int[,] myArray= GreatRandomZdArray();
Show2Array(myArray);
 int ElemPosition(int[,] array)
    {
        int elem=-1;
        Console.WriteLine("Введите какую позицию строки элемента искать i");
        int srtpos= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите какую позицию столбца элемента искать j");
        int stolbpos= Convert.ToInt32(Console.ReadLine());
        for( int i=0; i<array.GetLength(0); i++)
        {
            for( int j=0; j<array.GetLength(1); j++)
            {
                if(i==srtpos && j==stolbpos) elem=array[i,j];
                       
            }    
        }
        return elem;
     }
       

Console.WriteLine($"C такими индексами элемент в массиве равен  {ElemPosition(myArray)} , ( если -1 такого элемента нет");



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GreatRandomZdArray()
 {
    Console.WriteLine("Введите rowse  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите colums  ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максим  величину массива  ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальную  величину массива  ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows,colums];
    for( int i=0 ; i< rows ; i++)
    {
        for(int j=0 ; j< colums ; j++)
        {
            newArray[i,j]= new Random().Next( minvalue, maxvalue+1);
        }
    } 
    return newArray;
 }

void Show2Array (int[,] array)
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i, j]} ");
            }
        Console.WriteLine();
        }
 }
int[,] myArray= GreatRandomZdArray();
Show2Array(myArray);

string SredneeArifm(int[,] array )
{
    string sa=""; 
    double sum=0,n=0 , ar=0;
    for( int j=0 ; j < array.GetLength(1) ; j++)
    {
        for ( int i=0 ; i <  array.GetLength(0) ; i++)
        {
            sum=array[i,j]+ sum;
            n++;
        }
        ar=sum/n;
        sa=sa + Convert.ToString(Math.Round(ar,1))+" ";     
    }
    return sa;
}

Console.WriteLine($"среднее арифметическое элементов в каждом стобце { SredneeArifm(myArray)  } ");

*/