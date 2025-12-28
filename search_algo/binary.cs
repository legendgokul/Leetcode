static int binarySearch(int[] sortedArray, int target)
{
    int low = 0, high = sortedArray.Length;
    
    while(low<high)
    {
        var mid = (low+high) / 2;

        if(sortedArray[mid]== target)
        {
            return mid;
        }else if ( sortedArray[mid] > target )
        {
            high = mid-1;
        }else
        {
            low = mid+1;
        }
    }
    return -1;
}
   


Console.WriteLine("Binary Search Algo");

int[] inputArray = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20];
var target = 2;
var result =  binarySearch(inputArray,target);

Console.WriteLine("int[] inputArray = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20]; \nvar target = 2;");
Console.WriteLine($"Result: {result}");
