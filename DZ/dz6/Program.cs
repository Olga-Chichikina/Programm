// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

void ShowArray ( double[] array)    //  метод вывода на экран любого массива
  {
     for (double i=0; i<array.Length; i++) 
     Console.Write(array[i]+ "  ");
     Console.WriteLine();
  }
Console.WriteLine("Сколько чисел будете вводить ?");
double n = Convert.ToInt32(Console.ReadLine());
void Metod( double m)
{
    double j=0;
    double[] massiv=new double[m];
    for ( double i=0 ; i < n ; i++)
    {
        Console.WriteLine($"Введите {i} число ");
        double a = Convert.ToInt32(Console.ReadLine());
        massiv[i]= a;
            if( a > 0)
            {
            j++;
            }
    }        
    Console.WriteLine("Количество положительных чисел,введенных пользователем");
    Console.WriteLine(j);
    ShowArray(massiv);
}
Metod(n);
*/

//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Даны две прямые y=k1*x+b1 и y=k2*x+b2");
Console.WriteLine("Введите коэффициент  первой прямой к1");
double k1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  коэффициент  первой прямой b1");
double b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  коэффициент  второй прямой к2");
double k2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент  второй прямой b2");
double b2= Convert.ToInt32(Console.ReadLine());
if (k1 == k2 )
    {
    Console.WriteLine("Прямые параллельные, нет точки пересечения");
    }
     else
    {
    double x = (b2-b1) / (k1-k2);
    double y = b1 + k1 * (b2-b1) / (k1-k2);
    Console.WriteLine($"Точка пересечения прямых  x= {x}  , y= {y} ) ");
    }
   