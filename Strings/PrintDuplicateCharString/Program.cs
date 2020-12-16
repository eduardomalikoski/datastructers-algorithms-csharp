using System;

namespace PrintDuplicateCharString
{
    class Program
    {
        static string RemoveDuplicateChars(string key)
        {
            string table = "";
            string result = "";

            foreach (char value in key)
            {
                if (table.IndexOf(value) == -1) {
                    table += value;
                    result += value;
                }
            }
            return result;
        }
        static void Main()
        {
            string value1 = RemoveDuplicateChars("Csharpstar");
            string value2 = RemoveDuplicateChars("Google");
            string value3 = RemoveDuplicateChars("Yahoo");
            string value4 = RemoveDuplicateChars("CNN");
            string value5 = RemoveDuplicateChars("jojlja jajmjijgjo");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
        }
    }
}
