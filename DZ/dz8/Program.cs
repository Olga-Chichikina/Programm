// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

int[,] GreatRandomZdArray()  // создание двухмерного массива , заполненного случайными числами
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

void Show2Array (int[,] array)   // вывод двухмерного массива на экран
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i, j]} ");
            }
        Console.WriteLine();
        }
      Console.WriteLine();  
 }
int[,] myArray= GreatRandomZdArray();
Show2Array(myArray);

void ChahgeRows(int[,] array )  // программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.
{
    for( int i =0 ; i <  array.GetLength(0) ; i++)
    {
        for(int j=0; j< array.GetLength(1) ; j++ )
        {
           for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
             }
        }
    }
}
ChahgeRows (myArray);
Show2Array(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
/*
int[,] GreatRandomZdArray()  // создание двухмерного массива , заполненного случайными числами
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

void Show2Array (int[,] array)   // вывод двухмерного массива на экран
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i, j]} ");
            }
        Console.WriteLine();
        }
      Console.WriteLine();  
 }
int[,] myArray= GreatRandomZdArray();
Show2Array(myArray);

void FindMinSumElemRow(int[,] array)
    {
        int minRow = 0;
        int minSumRow = 0;
        int sumRow = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minRow =minRow + array[0, i];
        }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
                    if (sumRow < minRow)
                    {
                        minRow = sumRow;
                        minSumRow = i;
                    }
                sumRow = 0;
            }
        Console.Write($"{minSumRow + 1} строка");
    }

FindMinSumElemRow(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
/*
Console.WriteLine("Введитет данные первой прямоугольной матрицы");
int[,] GreatRandomZdArray()  // создание двухмерного массива , заполненного случайными числами
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

void Show2Array (int[,] array)   // вывод двухмерного массива на экран
 {
    for( int i=0; i < array.GetLength(0) ; i++)
        {
            for( int j=0; j < array.GetLength(1);  j++) 
            {
                Console.Write($" {array[i, j]} ");
            }
        Console.WriteLine();
        }
      Console.WriteLine();  
 }
int[,] array= GreatRandomZdArray();
Show2Array(array);

Console.WriteLine("Введитет данные второй  прямоугольной матрицы");
int[,] secondArray= GreatRandomZdArray();
Show2Array(secondArray);

Console.WriteLine();

int[,] resultArray= new int[array.GetLength(0),array.GetLength(1)];

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Console.WriteLine("результат произведение двух матриц ");
Show2Array(resultArray);

*/



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3 = new int[x, y, z];
CreateArray(array3);
WriteArray(array3);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
    //  Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3)
{
    int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                    {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                    }
                number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < array3.GetLength(0); x++)
    {
        for (int y = 0; y < array3.GetLength(1); y++)
        {
            for (int z = 0; z < array3.GetLength(2); z++)
            {
                array3[x, y, z] = temp[count];
                count++;
            }
        }
    }
}