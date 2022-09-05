
/*

int[] RandomArray(int size, int minValue, int maxValue)   // создает массив из случайных чисел
    {
        int[] newArray=new int[size];
            for( int i=0; i<size; i++)
            newArray[i]=new Random().Next(minValue,maxValue+1);
        return newArray;
    }
void ShowArray ( int[] array)    //  метод вывода на экран любого массива
    {
        for (int i=0; i<array.Length; i++) 
        Console.Write(array[i]+ "  ");
        Console.WriteLine();
    }
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин величину массива  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максим  величину массива  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray= RandomArray( size,min,max);
ShowArray(myArray);

//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)

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
Console.WriteLine();
myArray= ReversArray(myArray);
Console.WriteLine("Перевернутый одномерный массив ");
ShowArray(myArray);



/*
//Задача:Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.
bool Metod ( int a, int b , int c)
{
   if( a < (b+c) | b< (a+c) | c< (a+b)) return true;
    return false;
} 
   
Console.Write("Введите 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число");
int number2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 число");
int number3=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Cуществует ли треугольник со сторонами такой длины? {Metod(number1,number2,number3)}");

*/


//Задача:Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b

// int[] Fibonacci(int n, int a , int b)
//  {
//  int[] fib = new int [n];
//  fib[0] = a;
//  fib[1] = b;
//     for( int i=2; i < n ; i++)
//     {
//      fib[i] = fib[i-1] + fib [i-2];
//     }
//     return fib; 
//  }

// Console.Write("Введите количество чисел Фибоначи  ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите первое число а  ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число b  ");
// int b=Convert.ToInt32(Console.ReadLine());

// void ShowArray ( int[] array)    //  метод вывода на экран любого массива
//     {
//         for (int i=0; i<array.Length; i++) 
//         Console.Write(array[i]+ "  ");
//         Console.WriteLine();
//     }

// ShowArray(Fibonacci(n,a,b));

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string Binary (int num)
    {
     string elem=string.Empty;
        while (num > 0)
        {
        int n=num % 2 ;
        elem=Convert.ToString(n) + elem;
        num= num / 2;    
        }
     return elem;
    }

Console.Write("Введите число b  ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Binary(b));