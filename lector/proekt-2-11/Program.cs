void FillMassiv(int[]collection)
{
  int length = collection.Length;
  int index=0;
  while (index<length)
  {
  collection[index]=new Random().Next(1,10);
  index++;
  }
}

void PrintMassiv(int[] col)
{
int count = col.Length;
int position = 0;
while ( position < count )
{
    Console.WriteLine(col[position]);
    position++;
} 
}

int[] massiv= new int[10];
FillMassiv(massiv);
PrintMassiv(massiv);

 int Index(int[] massiv , int find )
 {
  int position=0;
  int i =0;
    while( i< massiv.Length)
    {
      if( massiv[i] == find)
      { 
        position = i ;
        break; 
      }
      else
      {
        position= -1;
      }
      i++;
    }
  return position;
 }
int pos = Index ( massiv, 21);
Console.WriteLine();
Console.WriteLine(pos) ;


