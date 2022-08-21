// нахождение максимального через массивы
/*int Max ( int arg1, int arg2, int arg3 )
{
  int result=arg1;
  if ( arg2 > result) result = arg2;
  if ( arg3 > result) result = arg3;
  return result;
} 

// индексы    0 1 2  3  4  5  6  7  8    в массиве
int[] array={18,2,53,84,59,60,72,8,999};  

int max = Max ( 
    Max (array[0] , array[1], array[2]),
    Max (array[3] , array[4], array[5]),
    Max (array[6] , array[7], array[8]) );
Console.WriteLine("Максимальное число равно");
Console.WriteLine(max);
*/

// Нахождение любого значения массива по индексу

int[] massiv={5,6,55,18,69,100,5,100};

int n=massiv.Length;
int find=100;
int index=0;

while (index<n)
{
  if (massiv[index]==find)
  
  Console.WriteLine(index);
  
  index++;  
}