﻿// оператор цикла
Console.Clear();
//Console.SetCursorPosition ( 10, 4 );
//Console.WriteLine(" + ");

int xa=8, ya=8, xb=25, yb=15, xc=50, yc=8;
Console.SetCursorPosition (xa,ya);
Console.WriteLine(" + ");
Console.SetCursorPosition(xb,yb);
Console.WriteLine(" + ");
Console.SetCursorPosition (xc,yc);
Console.WriteLine(" + ");
// определяем случайную точку

int x = xa , y = ya;

int count = 0;

while (count < 10000 )
{
   int wat = new Random().Next(0,3) ;
    if (wat == 0 ) 
    {
        x = ( x + xa) / 2 ;
        y = ( y + ya) / 2 ;
    }  
    if (wat == 1 ) 
    {
        x = ( x + xb) / 2 ;
        y = ( y + yb) / 2 ;
    }  
    if (wat == 2 ) 
    {
        x = ( x + xc) / 2 ;
        y = ( y + yc) / 2 ;
    }  
    Console.SetCursorPosition (x,y);
    Console.WriteLine(" + ");
    count=count+1; // можно записать count++;  
} 
