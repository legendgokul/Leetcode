int[] arr = { 9, 4, 8, 3, 1, 2, 5 };

void printArray(int[] array)
{
    foreach( var i in array)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}


Array.Sort(arr);
printArray(arr);