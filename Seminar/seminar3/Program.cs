// определить номер четверти плоскости, в которой находится точка с координатами x,y , причем x,y не равны нулю

/*
int Findchetplos (double xa , double ya)
{
if ( xa>0 && ya>0) return 1;
if ( xa>0 && ya<0) return 2;
if ( xa<0 && ya<0) return 3;
if ( xa<0 && ya>0) return 4;
return 0;
}

Console.Write("Введите координату х : " );
double x=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y : " );
double y=Convert.ToInt32(Console.ReadLine());

int kvad= Findchetplos (x,y);
Console.Write(" Четверть плоскости  " + kvad);
*/


//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
//точек в этой четверти (x и y).
/*
void Metod (int number)
{
if (number == 1) Console.WriteLine(" x>0   ,  y>0 ");
if (number == 2) Console.WriteLine(" x<0   ,  y>0 ");
if (number == 3) Console.WriteLine(" x<0   ,  y<0 ");
if (number == 4) Console.WriteLine(" x>0   ,  y<0 ");
else  Console.WriteLine ( "Это начало координат");
}

Console.Write(" Введите номер четверти плоскости : ");
int num=Convert.ToInt32(Console.ReadLine());
Metod(num);
*/

//Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n
/*
void Metod ( int n)
{
 int count = 1;   
while ( count <= n ) 
{
    Console.Write(count*count+ " ; ");
    count++;
}
}

Console.Write(" Введите число : ");
int num=Convert.ToInt32(Console.ReadLine());
Metod(num);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//Math.Sqrt()

double Distatn(double x1, double y1, double x2, double y2)
{
double dis=Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2));
return dis;
}

Console.Write("Введите координату хa : " );
double xa=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya : " );
double ya=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату хb : " );
double xb=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb : " );
double yb=Convert.ToInt32(Console.ReadLine());
double ras=Distatn(xa,ya,xb,yb);
Console.Write("Расстояние между точками в двухмерном пространстве : " + ras);
