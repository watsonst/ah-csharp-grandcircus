using System;

namespace _20210805
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Working with Strings

            string Hello = "Blue";
            string World = "Green";
            string Thought = "I am {0}";

            string result1 = Hello + " " + World;
            Console.WriteLine(result1);

            string result2 = string.Format("I am {0}, {1}", Hello, World);
            Console.WriteLine(result2);

            string result3 = $"I keep using {Hello} {World} as an example";
            Console.WriteLine(result3);

            string result4 = "This is line 1\n\tThis is \"line\" 2";
            Console.WriteLine(result4);

            string result5 = @"headline\n\tcell1\tcell2\tcell3";
            Console.WriteLine(result5);

            string justCell1 = result5.Substring(result5.IndexOf("cell1"), 5);
            Console.WriteLine(justCell1);

            int SecondCIndex = result5.LastIndexOf('c', result5.Length - 1);
            Console.WriteLine(SecondCIndex);
            Console.WriteLine(result5.IndexOf("cell2"));

            if(result5.Contains("cell1"))
            {
                Console.WriteLine("Yes it is there");
            }

            #endregion

            #region Implicit Conversions

            //int cost = 100;
            //double actualCost = cost;
            //var anotherCost = cost;
            //Console.WriteLine(cost);
            //Console.WriteLine(actualCost);
            //Console.WriteLine(anotherCost);

            #endregion

            #region Explicit Conversions

            //double startAsDouble = 100.50;
            //int endAsInt = (int)startAsDouble;
            //Console.WriteLine(startAsDouble);
            //Console.WriteLine(endAsInt);

            #endregion

            #region TryParse and Parse

            //string startAs100Double = "100";
            //var number = int.Parse(startAs100Double); // Can be unsafe

            //string startAs200Double = "200";
            //var userNumber = 0;
            //if (int.TryParse(startAs200Double, out userNumber))
            //{ // Safer way to parse to string
            //    Console.WriteLine("You can convert to int: " + userNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Nope... Sorry");
            //}

            #endregion
        }
    }
}
