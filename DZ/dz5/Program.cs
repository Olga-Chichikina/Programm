
// int[] RandomArray(int size, int minValue, int maxValue)   // создает массив из случайных чисел
//  {
//     int[] newArray=new int[size];
//         for( int i=0; i<size; i++)
//         newArray[i]=new Random().Next(minValue,maxValue+1);
//     return newArray;
//  }
// void ShowArray ( int[] array)    //  метод вывода на экран любого массива
//  {
//     for (int i=0; i<array.Length; i++) 
//     Console.Write(array[i]+ "  ");
//     Console.WriteLine();
//  }
// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите мин величину массива  ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максим  величину массива  ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] mymassiv=RandomArray(size,min,max);
// ShowArray(mymassiv);

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//  количество четных чисел в массиве
/*
int Count( int[] massiv)
{
    int  count=0;
    for (int i=0; i < massiv.Length; i++)
    {
        if( massiv[i] % 2 == 0 ) count++; 
    }
    return count;
}

Console.WriteLine($"КОЛИЧЕСТВО ЧЕТНЫХ ЧИСЕЛ В МАССИВЕ РАВНО {Count(mymassiv)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
//стоящих на нечётных позициях.

//программа ввывода суммы элементов, стоящих на нечетных(четных) позициях
/*

int  sumchet=0;
int sumnech=0;
    for (int i=0; i < mymassiv.Length; i++)
    {
        if( i % 2 == 0 ) sumchet = mymassiv[i]+ sumchet;
        else sumnech= mymassiv[i]+sumnech;
    }

Console.WriteLine("Сумма элементов в одномерном массиве , стоящих на нечетных позициях "+ sumnech );
Console.WriteLine("Сумма элементов в одномерном массиве , стоящих на четных позициях "+ sumchet );

*/




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.вщг
double MaxElem(double[] massiv) // метод нахождения максимального элемента массива
   {
        double max = massiv[0];
        for( int i = 1 ; i < massiv.Length ; i++)
        {
            if (massiv[i]> max)  max= massiv[i]  ;
        }
        return max;
    }

double MinElem(double[] massiv) // метод нахождения минимального  элемента массива 
    {
        double min =  massiv[0];
        for( int i = 1 ; i < massiv.Length ; i++)
        {
            if (massiv[i]< min)  min= massiv[i]  ;
        }
        return min;
    }


 void ShowArray ( double[] array)    //  метод вывода на экран любого массива
  {
    for (int i=0; i<array.Length; i++) 
     Console.Write(Math.Round(array[i],2)+ "  ");
     Console.WriteLine();
  }

double[] RandomArray(int size)   // создает массив из случайных вещественных  чисел
 {
    double[] newArray=new double[size];
        for( int i=0; i<size; i++)
        {
        newArray[i]=new Random().NextDouble()*100;
        }
        return newArray;
 }

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] mymassiv=RandomArray(size);
ShowArray(mymassiv);
double rasn=MaxElem(mymassiv)-MinElem(mymassiv);
Console.WriteLine($"Разница между максимальным {MaxElem(mymassiv)} и минимальным {MinElem(mymassiv)} элементами равна" + rasn);


