void Generation(int[] collection)
{
    int index_generation = 0;
    while(index_generation < collection.Length)
    {
        collection[index_generation] = new Random().Next(100, 1000);
        index_generation++;
    }
}
void PrintArray(int[] print)
{
    int position = 0;
    Console.Write("{");
    while(position < print.Length)
    {
        
        Console.Write(print[position] );
        Console.Write(", ");
        
        position++;
    }
    Console.Write("}");
    Console.WriteLine(" ");
}
int[] array = new int[10];
int temp;
Generation(array);
PrintArray(array);
for (int i = 0; i < array.Length / 2; i++)
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i]; 
    array[array.Length - 1 - i] = temp; 
}
Console.Write("\nПеревернутый массив: ");
PrintArray(array);