int[] oldArray = new int[5];
int[] newArray = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please input a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    oldArray[i] = num;
}

for (int i = 0; i < oldArray.Length; i++)
{
    newArray[i] = oldArray[i];
    Console.WriteLine($"Old Array: {oldArray[i]}");
    Console.WriteLine($"New Array: {newArray[i]}");
}