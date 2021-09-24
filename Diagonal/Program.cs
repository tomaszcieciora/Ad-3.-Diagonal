using System;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ad 3. DDiagonal

            Console.WriteLine("Enter the lenght");
            double lenght = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width");
            double width = double.Parse(Console.ReadLine());
            double diagonal1 = (int) Math.Pow(lenght, 2);
            double diagonal2 = (int) Math.Pow(width, 2);
            double element = Math.Sqrt((diagonal1 + diagonal2));
            Console.WriteLine("Squared lenght="+ diagonal1);
            Console.WriteLine("Squared width="+ diagonal2); 
            Console.WriteLine("Diagonal="+ element);

        }

       
    
    }
}
