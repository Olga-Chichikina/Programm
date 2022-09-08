/*
int[] ReversArray( int[] array)  // метод переворачивает массив, делает его зеркальным

 {
    for(int i=0,j=(array.Length-1); i < j ; i++ , j--)
   {
        int temp= array[i];
        array[i]= array[j];
        array[j]=temp;
   }
   return array;
 }




//
/*
// массив строк 
string[,] table= new string[2,5];
// string=Empty;  - инициализация строк
//  [0,0]  [0,1]  [0,2 ]  [0,3]   [0,4]
//  [1,0]  [1,1]  [1,2 ]  [1,3]   [1,4]

table [ 1,2] = "слово";
    for( int i=0; i < 2 ; i++)
    {
        for( int j=0; j < 5;  j++) 
        {
        Console.WriteLine($"- { table[i, j]}- ");
        }
    }


     
int[,] matrix= new int[2,5];   //  двумерный массив чисел
 for( int i=0; i < matrix.GetLength(0) ; i++)
    {
        for( int j=0; j < matrix.GetLength(1);  j++) 
        {
        Console.Write($" { matrix[i, j]} ");
        }
        Console.WriteLine();
    }


void PrintArray ( int[,] mat)   // метод печати двумерного массива 
    {
    for( int i=0; i < mat.GetLength(0) ; i++)
        {
            for( int j=0; j < mat.GetLength(1);  j++) 
            {
            Console.Write($" { mat[i, j]} ");
            }
            Console.WriteLine();
        }
    }
void FillArray(int[,] matrix) // метод создания двумерной матрицы случайными числами
    {
        for( int i = 0 ; i < matrix.GetLength(0) ; i++ )
         {
            for( int j = 0 ; j < matrix.GetLength(1); j++) 
                {
                    matrix[i,j] = new Random().Next(1,10);
                }
        }
    }
int[,] matrix = new int [2,5];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

*/

//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.
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
            newArray[i,j]= i+j;
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
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
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
int[,] ArrayNew(int[,] array)
    {
        for( int i=0; i<array.GetLength(0); i++)
        {
            for( int j=0; j<array.GetLength(1); j++)
            {
                if(i%2==0 && j%2==0) array[i,j]=array[i,j]*array[i,j];
            }    
        }
        return array;
     }

Console.WriteLine();
ArrayNew(myArray);
Show2Array(myArray);
*/

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.

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
int SumElem(int[,] array)
    {
        int sum=0;
        for( int i=0; i<array.GetLength(0); i++)
        {
            for( int j=0; j<array.GetLength(1); j++)
            {
                if(i==j) sum=sum+array[i,j];
            }    
        }
        return sum;
     }

Console.WriteLine();
Console.WriteLine($"Сумма элементов массива на диагонали при совпадении индексов массива  {SumElem(myArray)}");
*/



