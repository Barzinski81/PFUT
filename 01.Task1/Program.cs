namespace _01.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("0");
            }

            else
            {

                int cumulativeWater = 0;

                for (int i = 0; i < n; i++)
                {
                    int dailyWaterAmount = int.Parse(Console.ReadLine());

                    cumulativeWater += dailyWaterAmount;

                    Console.WriteLine(cumulativeWater);
                }

            }  
        }
    }
}
