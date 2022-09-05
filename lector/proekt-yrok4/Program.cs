
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


  // двумерный массив чисел      
int[,] matrix= new int[2,5];
 for( int i=0; i < matrix.GetLength(0) ; i++)
    {
        for( int j=0; j < matrix.GetLength(1);  j++) 
        {
        Console.Write($" { matrix[i, j]} ");
        }
        Console.WriteLine();
    }

// метод печати двумерного массива 

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



int[,] pic = new int[5,9] ;


s[i] = Console.ReadLine();
{     
      { 0 ,1, 1, 1, 1, 1, 1, 1, 0 },
      { 0 ,1, 0, 0, 0, 0, 0, 1, 0 },
      { 0 ,0, 1, 0, 0, 0, 1, 0, 0 },
      { 0 ,0, 0, 1, 0, 1, 0, 0, 0 },
      { 0, 0, 0, 0, 1, 0, 0, 0, 0 };
};
       


void PrintImage(int[,] image)  // метод печати изображения
    {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++)
                {
                if(image[i,j] == 0) Console.Write($" ");
                 else Console.Write($"+");
                }
            Console.WriteLine();
        }
    }

PrintImage(pic);


void PrintImage(int[,] image)  // метод печати изображенияб выделения контура рисунка
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
        if(image[i,j] == 0) Console.Write($" ");
        else Console.Write($"+");
        }
    Console.WriteLine();
    }
}

void FillImage(int row, int col)  // закрашивание пикселей
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
Console.WriteLine();
FillImage(5, 5);
PrintImage(pic);
*/

// Факториал через рекурсию

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
    {
    Console.WriteLine($"{i}! = {Factorial(i)}");
    }

// Числа Фибоначи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}


for (int i = 1; i < 10; i++)
{
 Console.WriteLine(Fibonacci(i));
}




