using System; //implementation of decision making

namespace Harendra
{
    class Prajapati
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number to check thne number is odd or Even");
            int i = Convert.ToInt16(Console.ReadLine());
            if (i%2==0)
            {
                Console.WriteLine(i+" is an Even Number");

            }
            else
            {
                Console.WriteLine(i + " is an Odd Number");
            }

        }
    }
}
