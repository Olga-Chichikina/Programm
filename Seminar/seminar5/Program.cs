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

/*
int FindPositivSumn(int[] array)
{
    int sum=0;
    for (int i=0;i<array.Length ; i++)
        if(array[i] > 0) sum+=array[i];
        return sum;
}
int FindNegativSumn(int[] array)
{
    int sum=0;
    for (int i=0;i<array.Length ; i++)
    {
        if(array[i] < 0) sum+=array[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин величину массива  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максим  величину массива  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray= RandomArray( size,min,max);
ShowArray(myArray);

int positivSum=FindPositivSumn(myArray);
int negativSum=FindNegativSumn(myArray);
Console.WriteLine("Сумма отрицательных чисел в массиве  " + negativSum);
Console.WriteLine("Сумма положительных чисел в массиве  " + positivSum);
*/



/*
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
int[] ObrArray(int[] array)
{
    for( int i = 0; i< array.Length ; i++) 
       array[i]=-array[i];
       return array;
}
int[] mymassiv=RandomArray(size,min,max);
ShowArray(mymassiv);
int[] mymas=ObrArray(mymassiv);
ShowArray(mymas);

//Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool FindNumber(int[] array , int n)
{
    for( int i=0 ; i<array.Length ; i++)
    {
        if ( array[i]== n ) return true;
    }
    return false;
}
int[] mymassiv=RandomArray(size,min,max);
ShowArray(mymassiv);
Console.WriteLine("введите число");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Данное число есть в массиве?{FindNumber(mymassiv,number)}");
*/

//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат
// в отрезке [10,99].

int Count (int[] array)
{
int count=0;
for ( int i=0 ; i< array.Length ; i++)
{
if ( array[i] >10 && array[i] <100 ) count++;
}
return count;
}

int[] mymassiv=RandomArray(size,min,max);
ShowArray(mymassiv);
Console.WriteLine ($"количество элементов в массиве {Count(mymassiv)} ");


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй 
//и предпоследний и т.д. Результат запишите в новом массиве.

