
using System;

namespace WappTestConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var resp = CheckNumber(8763);

            if (resp)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");

            Console.ReadLine();
        }

        private static bool CheckNumber(Int32 number)
        {
            ServiceReferenceCheckNumbers.WServiceSoapClient serviceReference = new ServiceReferenceCheckNumbers.WServiceSoapClient();

            return serviceReference.CheckNumber(number);
        }
    }
}