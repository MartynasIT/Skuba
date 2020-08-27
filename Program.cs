using System;

namespace Kartotinis
{
    class Program
    {
        public static void CalculateKartotinis()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Sku");
                }

                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("ba");
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Skuba");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            CalculateKartotinis();
        }
    }
}
