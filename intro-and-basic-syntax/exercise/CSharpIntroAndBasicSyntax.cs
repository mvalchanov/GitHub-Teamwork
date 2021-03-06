﻿using System;

namespace CSharpIntroAndBasicSyntax
{
    class CSharpIntroAndBasicSyntax
    {
        static void Main()
        {
            int buffer = 1;
            string output = String.Empty;
            while (buffer <= 4)
            {
                string integers = Console.ReadLine();
                if (integers.Length < 4)
                {
                    integers = FormatIntegers(integers);
                }

                output += integers + " ";
                buffer++;
            }
            
            Console.WriteLine(output.Trim());
        }

        static string FormatIntegers(string integers)
        {
            return integers.PadLeft(4, '0');
        }
    }
}
