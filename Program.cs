
int[] arr = new int[5];
var sum = 0;
var average = 0.0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the Element {0}", i + 1);
    arr[i] = Convert.ToInt32(Console.ReadLine());
    sum += arr[i];
   
}
average = (double)sum / arr.Length;

Console.WriteLine("Elements greater than Average:");
    for (int i = 0; i < arr.Length; i++)
    
        if (arr[i] > average)
        {
            Console.WriteLine(arr[i]);
        }

Console.WriteLine("Average of all Elements is: {0}", average); 

