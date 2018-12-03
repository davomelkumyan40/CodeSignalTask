// FINISHED WORK ANY POLINDROM

using System;

namespace CodeSignalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string not_Polindrom_String = "AAAASSDDDFFFF";
            Console.WriteLine(AnyPolindrom(not_Polindrom_String));
            Console.ReadKey();
        }

        public static bool CharChecker(string str)
        {
            char[] someArray = str.ToCharArray();
            char previousLetter = ' ';
            int letterCount = 0, oddCount = 0; ;
            char letter = someArray[0];
            for (int j = 0; j < someArray.Length; j++)
            {
                if(previousLetter != someArray[j])
                {
                    letter = someArray[j];
                    for (int i = 0; i < someArray.Length; i++)
                    {
                        if (letter == someArray[i])
                            letterCount++;
                    }
                    if (letterCount % 2 > 0)
                        oddCount++;
                    else
                        previousLetter = letter;
                    if (oddCount > 1)
                        return false;
                }
            }
            return true;
        }

        public static bool AnyPolindrom(string someString)
        {
            if (someString.IsPolindrom())
            {
                return true;
            }
            else
                if (CharChecker(someString))
                return true;

            return false;
        }
    }
}
