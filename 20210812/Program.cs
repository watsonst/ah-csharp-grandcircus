using System;

namespace _20210812
{
    class Program
    {
        public static void myCopyMethod(char[] strOne, char[] strTwo, int index)
        {
            if (index < 0)
            {
                return;
            }

            strTwo[index] = strOne[index];

            myCopyMethod(strOne, strTwo, index - 1);
        }

        public static void myCopyMethodWithLoop(char[] strOne, char[] strTwo)
        {
            for (var i = 0; i < strOne.Length; i++)
            {
                strTwo[i] = strOne[i];
            }
        }

        static void Main(string[] args)
        {
            string testString = "This is a new example";

            char[] testStringChar = testString.ToCharArray();
            char[] newStringChar = new char[testString.Length];

            Console.WriteLine(testStringChar.Length);
            Console.WriteLine(newStringChar.Length);

            //myCopyMethod(testStringChar, newStringChar, newStringChar.Length - 1);
            myCopyMethodWithLoop(testStringChar, newStringChar);

            Console.WriteLine(testStringChar);
            Console.WriteLine(newStringChar);
        }

    }
}
