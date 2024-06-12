using System.ComponentModel.Design;
using System.Net.Security;

namespace ifstatement_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string answer = Console.ReadLine();

            int aNumber = Convert.ToInt32(answer);

            if (aNumber % 2 == 0)
            {Console.WriteLine($"{aNumber} is even.");}
            else{Console.WriteLine($"{aNumber} is odd.");}

            
        }
    }
}
