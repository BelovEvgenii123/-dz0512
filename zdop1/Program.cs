


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
        
}


void ReleaseArray(int[] array)
{
    int count3 = 0, count4 = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if (array[i] %2 !=0)
        {
            Console.Write(array[i] + "  ");
            count3 ++;
        }
        }
        Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] %2 ==0)
        {
            Console.Write(array[i] + "  ");
            count4 ++;
        }
        }
    Console.WriteLine();
    
    if (count4>count3)
    Console.WriteLine("yes");
    else
    Console.WriteLine("no"); 
}


Console.Clear();
Console.Write("Введите кол-во элементов массива от 1 до 100: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);