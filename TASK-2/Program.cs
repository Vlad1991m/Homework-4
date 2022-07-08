int[] CreateArray(int size)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++) 
    newArray[i] = new Random().Next(1,100);
    return newArray;
}
void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
    Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
}
Console.Write("Input size of array: "); 
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArray(size);
ShowArray(array);
