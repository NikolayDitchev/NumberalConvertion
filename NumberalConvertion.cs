using System;

namespace NumberalConvertion
{
    class NumberalConvertion
    {
        static void Main(string[] args)
        {
            String Reverse(String s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new String(charArray);
            }

            int toDecimal(int system, String input)
            {
                int decNumber = 0;
                if(system == 16)
                {
                    decNumber = Convert.ToInt32(input, 16);
                }
                else
                {
                    for(int i = 0; i < input.Length; i++)
                    {
                        int temp = input[i] - '0';
                        for(int p = 0; p < input.Length - i - 1; p++)
                        {
                            temp *= system;
                        }
                        decNumber += temp;
                    }
                }

                return decNumber;
            }

            String fromDecimal(int system, int dec)
            {
                String output = "";
                if(system == 16)
                {
                    output = dec.ToString("X");
                }
                else
                {
                    while(dec != 0)
                    {
                        int temp = dec % system;
                        output += temp.ToString();
                        dec = dec / system;
                    }
                    output = Reverse(output);
                }
                return output;
            }

            Console.Write("Input type (2, 8, 10, 16):");
            int systemInput = Convert.ToInt32(Console.ReadLine());
            int decNumber = 0;
            if(systemInput != 10)
            {
                Console.Write("Input non-decimal number:");
                String inputString = Console.ReadLine();
                decNumber = toDecimal(systemInput, inputString);
            }
            else
            {
                Console.Write("input the decimal number:");
                decNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the ouput system:");
            int systemOutput = Convert.ToInt32(Console.ReadLine());
            if(systemOutput == 10)
            {
                Console.WriteLine(decNumber);
            }
            else
            {
                Console.WriteLine(fromDecimal(systemOutput, decNumber));
            }

            Console.Write("type something to close:");
            string us = Console.ReadLine();
        }
    }
}
