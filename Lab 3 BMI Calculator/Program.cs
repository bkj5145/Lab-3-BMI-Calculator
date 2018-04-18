using System;

namespace Lab_3_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblHeight;
            double dblWeight;
            double dblBMI;

            Console.WriteLine("Enter you Height in inches: ");
            dblHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Weight in pounds: ");
            dblWeight = int.Parse(Console.ReadLine());

            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

            Console.WriteLine("Your BMI is " + dblBMI);

            if (dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
            else if (dblBMI <= 24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
            }
            else if (dblBMI <=29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 - Overweight");
            }
            else
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }

            Console.ReadLine();


        }
    }
}
