using System;

namespace Application
{
    public class TheForthNumber
    {
        //function for finding the forth number
        public static int FindTheForthNumber(int n)
        {
            //initializing the first 4 numbers
            List<int> series = new List<int> { 1,2,3,4};

            //calculating the nth number
            for (int i = 4; i < n; i++) 
            { 
            int nextNumber = series[i - 1] + series[i -2 ]+ series[i - 3] + series[i -4];
                series.Add(nextNumber);

                    }
            //returns the nth number(1-indexed)
            return series[n-1];
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1|| n> 50)
            {
                Console.WriteLine("n must be between 1 and 50");
            }
            else
            {
                //calling the function
                int results =FindTheForthNumber(n);
                Console.WriteLine($"the {n}th number in the series is:{results} ");
            }
        }
    }
}