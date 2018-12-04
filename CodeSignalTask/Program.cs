// FINISHED WORK ANY POLINDROM

using System;
using System.Linq;

namespace CodeSignalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string not_Polindrom_String = "aab";
            Console.WriteLine(palindromeRearranging(not_Polindrom_String));
            Console.ReadKey();
        }

        static bool palindromeRearranging(string inputString)
        {
            if (IsPolindrom(inputString))
            {
                return true;
            }
            else if (CharChecker(inputString))
                return true;

            return false;
        }
        static bool CharChecker(string inputString)
        {
            char[] someArray = inputString.ToCharArray();
            char previousLetter = someArray[0];
            int letterCount = 0, oddCount = 0;
            char letter = someArray[0];
            for (int j = 0; j < someArray.Length; j++)
            {
                letter = someArray[j];
                if (previousLetter != someArray[j] || previousLetter == someArray[0])
                {
                    for (int i = 0; i < someArray.Length; i++)
                    {
                        if (letter == someArray[i])
                            letterCount++;
                    }
                    if (letterCount % 2 != 0)
                        oddCount++;

                        previousLetter = letter;

                    if (oddCount > 1)
                        return false;
                }
                letterCount = 0;
            }
            return true;
        }

        static bool IsPolindrom(string inputString)
        {
            if (inputString == ReverseString(inputString))
                return true;
            else
                return false;
        }


        static string ReverseString(string inputString)
        {
            string s = null;
            foreach (var item in inputString.Reverse())
            {
                s += item;
            }
            return s;
        }
    }
}
