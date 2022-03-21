using System;

namespace BMI__if_else_else_if_Vezba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tezina");
            double tezina = double.Parse(Console.ReadLine());

            Console.WriteLine("Visina");
            double visina = double.Parse(Console.ReadLine());

            Console.WriteLine("BMI" + (tezina / (visina * visina)).ToString());
            if ((tezina / (visina * visina)) < 16)
            {
                Console.WriteLine("Underweight (Severe thinness) ");
            }
           else if ((tezina / (visina * visina)) < 16.9) 
            {
                Console.WriteLine ("Underweight (Moderate thinness) ");

            }
            else if ((tezina / (visina * visina)) <18.4)
            {
                Console.WriteLine ("Underweight (Mild thinness)" );

            }    
            else if ((tezina / (visina * visina))<24.9)
            {
                Console.WriteLine("Normal range");
            }
            else if ((tezina / (visina * visina))<29.9)
            {
                Console.WriteLine("Overweight (Pre-obese)");
            }
            else if ((tezina / (visina * visina)) <34.9)
            {
                Console.WriteLine("Obese(Class 1)");
            }
            else if ((tezina / (visina * visina))<39.9)
                {
                Console.WriteLine("Obese Class2)");
            }
            else 
                    {
                Console.WriteLine("Obese 3");

            }
        }
    }
}
