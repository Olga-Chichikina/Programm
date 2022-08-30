//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число");
string s = Console.ReadLine();
void Palindrom( string n)
{
    for (int i = 0; i < n.Length/2; ++i)
        if (n[i] !=  n[n.Length-1-i] ) 
        {
        Console.WriteLine("Не палиндром");
        }
        else
        {
         Console.WriteLine("число является полиндромом");
        }
}
Palindrom(s);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
void Distatn(double x1, double y1, double x2, double y2, double z1, double z2 )
{
double dis=Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
Console.Write("Расстояние между точками в трехмерном пространстве : " + dis);
}

Console.Write("Введите координату хa : " );
double xa=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya : " );
double ya=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату хb : " );
double xb=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb : " );
double yb=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату za : " );
double za=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату zb : " );
double zb=Convert.ToInt32(Console.ReadLine());

Distatn(xa,ya,xb,yb,za,zb);
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* 
void Metod ( int arg)
{
int count=1;
 Console.WriteLine("Кубы целых чисел   до этого числа равны  ");
while (count <= arg )
{
    Console.Write (" " + count*count*count + " : ");
    count++;
}
}
Console.Write("Введите любое целое число");
int number=Convert.ToInt32(Console.ReadLine());
Metod(number);
*/
