


void printArray()
{
    for(int i=0; i< arr.Length; i++ )
    {
        Console.Write(arr[i]);
    }
}

int[] arr = new int[] { 3, 2, 5, 7, 4, 6, 1 };

void sortArray()
{
    for ( int i=0;i< arr.Length;i++ )
    {
        int min_Index = i; 

        for(int j=i+1; j<arr.Length; j++)
        {
            if(arr[i] > arr[j])
            {
              min_Index = j;   
            }
        }

        // swap logic to move small numbers to the begining :
        var temp = arr[min_Index];
        arr[min_Index] = arr[i];
        arr[i] = temp;
    }
}

Console.WriteLine("Before :");
printArray();

sortArray();

Console.WriteLine("\nAfter :");
printArray();
