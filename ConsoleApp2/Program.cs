using System.Security.Principal;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Del 1 av den oppgaven ble brukt på guess number oppgaven.
            Console.WriteLine("Hello, choose 2 numbers.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int x = Ave.add(num1, num2);
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} x {num2} = {x}");
            }
            else
            {
                Console.WriteLine($"{num1} + {num2} = {x}");
            }


            Console.WriteLine("Checking...");
            bool trueFalse = Ave.checkIf(x);
            if (trueFalse)
            {
                Console.WriteLine("The number is 30.");
                Environment.Exit(0);
            }

            Console.WriteLine($"Number is not 30, its {x}");
        }
    }
}