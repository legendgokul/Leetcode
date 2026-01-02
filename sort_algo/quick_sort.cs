Console.WriteLine("QuickSort");

void printArray(int[] array)
{
    foreach( var i in array)
    {
        Console.Write(i);
    }
    Console.WriteLine("");
}

void swap(int[] arr, int i, int j)
{
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

//Lomuto partition scheme
int findPivot(int[] arr, int low, int high)
{
    // taking last element as pivot.
    var pivot = arr[high];
    int i = low -1;

    for (int j = low; j< high; j++)
    {
        if(arr[j]<pivot)
        {
            //increment i and swap
            i = i+1;
            swap(arr,i,j);
        }
    }

    //post above logic all small and larger numbers will be sorted so we swap i+1 index with pivot.
    swap(arr,i+1, high);
    return i+1;
}

void QuickSort(int[] arr, int low, int high)
{
    if(low<high)
    {
        // sort arry and find a pivot which has less item on left and larger item on right.
        var pivot_index = findPivot(arr,low,high);

        // recursive quick sort
        QuickSort(arr, low, pivot_index-1);
        QuickSort(arr, pivot_index+1, high);
    }
}


int[] arr = { 9, 4, 8, 3, 1, 2, 5 };

Console.Write($"Before ");
printArray(arr);

QuickSort(arr, 0, arr.Length-1);

Console.Write($"After: ");
printArray(arr);
