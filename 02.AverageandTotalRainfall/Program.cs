namespace _02.AverageandTotalRainfall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dailyRain = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int nStart = int.Parse(Console.ReadLine());
            
            int mEnd = int.Parse(Console.ReadLine());

            double totalRain = 0;

            for (int i = nStart ; i <= mEnd; i++)
            {
                int dailyAmount = dailyRain[i];

                totalRain += dailyAmount;
 
            }

            Console.WriteLine(totalRain);

            Console.WriteLine($"{ totalRain / (mEnd - nStart + 1):F2}");

        }
    }
}
