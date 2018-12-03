using System.Linq;

namespace CodeSignalTask
{
    public static class Extensions
    {
        public static bool IsPolindrom(this string someString)
        {
            if (someString == someString.ReverseString())
                return true;
            else
                return false;
        }

        public static string ReverseString(this string str)
        {
            string s = null;
            foreach (var item in str.Reverse())
            {
                s += item;
            }
            return s;
        }
    }
}
