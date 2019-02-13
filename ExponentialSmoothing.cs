using System;

namespace SCMProblemSolver
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Welcome to Exponential Smoothing");
            Console.WriteLine();
          
          
          
                Console.WriteLine("Enter the previous period forecasted value");
                double forecast;
                
                forecast = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the actual demand value for the period");
                double demand;
                demand = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the alpha value");
                double alpha;
                alpha = Convert.ToDouble(Console.ReadLine());
                double resultCase1;
                resultCase1 = forecast+(alpha * (demand-forecast));
                Console.WriteLine("The exponential smoothed value is {0}", resultCase1);
             
            
            Console.WriteLine("Press enter to continue...");
            Console.Read();
        }
          
    }
}
