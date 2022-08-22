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
