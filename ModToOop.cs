
namespace NumAvg
{

    public class Greater
    {
        public int[] Arr(int[] arr)

        {
            var sum = 0;
            var average = 0;


            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                sum += arr[i];
                average = sum / arr.Length;

            }

            Console.WriteLine($"TheAverage={average}");


            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] > average)
                {
                    Console.WriteLine($"TheNumberGreaterThanAvg={arr[x]}");
                }
            }
            return arr;

        }

    }

}