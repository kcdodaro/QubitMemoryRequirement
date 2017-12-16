using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QuantumMemoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger memory = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i == 1)
                {
                    memory = 16;
                }
                else
                {
                    memory *= 2;
                }

                Console.WriteLine(i + ": " + formatMemory(memory) + " required");
            }

            Console.ReadKey();
        }

        static string formatMemory(BigInteger memory)
        {
            BigInteger ram = memory;
            int intAmountDivides = 0;

            while (ram >= 1024)
            {
                    ram /= 1024;
                    intAmountDivides++;
            }

            string suffix = null;

            switch (intAmountDivides)
            {
                default:
                    suffix = "bytes";
                    break;
                case 1:
                    suffix = "kilobytes";
                    break;
                case 2:
                    suffix = "megabytes";
                    break;
                case 3:
                    suffix = "gigabytes";
                    break;
                case 4:
                    suffix = "terabytes";
                    break;
                case 5:
                    suffix = "petabytes";
                    break;
                case 6:
                    suffix = "exabytes";
                    break;
                case 7:
                    suffix = "zettabytes";
                    break;
                case 8:
                    suffix = "yottabytes";
                    break;
            }

            return ram + " " + suffix;
        }
    }
}