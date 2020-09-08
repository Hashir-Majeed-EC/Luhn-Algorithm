using System;

namespace Luhn_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = "";
            Console.WriteLine("Enter Credit Card Number: ");
            card = Console.ReadLine();
            Console.WriteLine(checkSum(card));
        }

        static bool checkSum(string creditCard)
        {
            bool checksum = false;
            int total = 0;

            for (int i = 0; i < creditCard.Length; i ++)
            {
                if (i % 2 == 0)
                {
                    total += calc(Convert.ToInt32(creditCard[i]) - 48);
                }
                else
                {
                    total += Convert.ToInt32(creditCard[i] - 48);
                }
            }

            if (total % 10 == 0)
            {
                checksum = true;
            }

            return checksum;
        }

        static int calc(int num)
        {
            num = num * 2;
            if (num > 9)
            {
                num -= 9;
            }

            return num;
        }
    }
}
