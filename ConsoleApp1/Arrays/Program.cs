//inserting in array first element.

//Creating array :
Console.WriteLine("creating array");
int[] arr = new int[7];
int temp = 0;
for (int i = 0;i < arr.Length; i++)
{
    arr[i] = temp;
    temp++;
}
foreach (int i in arr)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("------------------ Insertion process: ");
{ 
for(int i = arr.Length - 1; i > 0; i--)
{
    arr[i] = arr[i - 1];
}
arr[0] = 12; //insertion
foreach (var item in arr)
{
    Console.Write(item+" ");
}
}
//------------------------
//inserting anywhere in the array :\
Console.WriteLine();
Console.WriteLine("Give your desired value: ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine("Give the index of the value you want to be set off: ");
var input =int.Parse(Console.ReadLine());
{
    for (int i = arr.Length-1; i >= input ; i--)
    {
        arr[i] = arr[i - 1];
    }
    arr[input] = value;

    foreach (var item in arr)
    {
        Console.Write(item+" ");
    }
}
