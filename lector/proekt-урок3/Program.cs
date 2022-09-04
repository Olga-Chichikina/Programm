// типы методов
// тип 1 : не принимают , не возвращают
/*
void Metod()
{
    Console.WriteLine(" Автор .....");
}
Metod();    // вызов метода


// тип 2 Метод принимает значения , но не возвращает
void Metod2( string tekst, int count)
{
    int i=0;
    while( i< count)
    {
        Console.WriteLine( tekst);
        i++;
    }
}
Metod2( tekst: " Привет , Ольга! ", count: 5);   // вызов метода
*/

// тип3 Метод принимает, но не возвращает
/*
int Metod3()
{
return DataTime.Now.Year;
}

int year= Metod3();
Console.WriteLine(year);


// тип 4 Метод принимает, возвращает

string Metod4( int count, string c)
{
    int i=0;
    string result= String.Empty; // или string result="" ;
    while( i< count)
    {
        result=result+c;
        i++;
    }
    return result;
}
string res=Metod4(5, " Привет");
Console.WriteLine(res);
*/

// ТАБЛИЦА УМНОЖЕНИЯ 
 for(int i=1; i<10 ; i++)
 {
    for(int j=1; j<10 ; j++)
    {
     Console.WriteLine($" { i } x { j } = { i*j} ");  
    }
    Console.WriteLine();
 }
 
//  упорядочивание массива 
/*
int[] arr = { 2,6,9,8,15,3,6};
void PrintMassiv ( int[] array)
{
    for(int i=0 ; i< array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintMassiv(arr);

int[] SelecSort( int[] array)
{
    for( int i=0; i < array.Length-1; i++)
    {
    int minPos=i;
        for( int j=i+1 ; j < array.Length ; j++)
        {
            if(array[j]< array[minPos]) 
            {
                minPos=j;
            }
        } 
      
     int temp = array[i];
     array[i]= array[minPos];
     array[minPos]=temp;
    }
    return array;
}
SelecSort(arr);
*/