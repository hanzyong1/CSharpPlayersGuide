// minimum
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int num in array)
{
    if (num < currentSmallest)
    {
        currentSmallest = num;
    }
}
Console.WriteLine(currentSmallest);

// average
int[] array2 = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (int num in array2)
{
    total += num;
}
float average = (float)total / array2.Length;
Console.WriteLine(average);