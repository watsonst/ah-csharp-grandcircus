using System;

namespace _20210811
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            try
            {
                // Example 2
                //var result = BubbleUpException();

                // Example 3
                // var exampleString = "cookies";
                // var result = IsStringADayOfTheWeek(exampleString);
                // var YesOrNo = result ? "Yes" : "No";
                // Console.WriteLine($"Is {exampleString} a day of the week?: {YesOrNo}.");

                // Example 1 & 4
                IndexOutOfRange();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"The Argument was out of range of the expected value");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"The Argument named {ex.ParamName} has an unexpected value");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Complete");
            }

        }


        #region Throw

        // In this method we will throw an exception
        public static bool IsStringADayOfTheWeek(string dayOfTheWeek)
        {
            var result = false;

            switch (dayOfTheWeek)
            {
                case "Monday":
                    result = true;
                    break;
                case "Tuesday":
                    result = true;
                    break;
                case "Wednesday":
                    result = true;
                    break;
                case "Thursday":
                    result = true;
                    break;
                case "Friday":
                    result = true;
                    break;
                default:
                    throw new ArgumentException($"{dayOfTheWeek} is not a valid input.", "dayOfTheWeek");
                    //throw new Exception($"Your value of 'dayOfTheWeek': {dayOfTheWeek} is not a valid input.");
            }
            
            return result;
        }

        #endregion


        #region Try, Catch, Finally

        public static string BubbleUpException()
        {
            string[] week = {"9", "10", "11", "12", "13"};
            int index = 5;
            bool wasThereAnError = false;
            string result = string.Empty;

            result = week[index];

            return result;
        }

        // the parameter of 'index' has a default value of 0
        public static string IndexOutOfRange(int index = 0)
        {
            string[] week = {"9", "10", "11", "12", "13"};
            bool wasThereAnError = false;
            string result = string.Empty;

            try
            {
                result = week[index];
                Console.WriteLine(result);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"There is a problem with the index: {ex.Message}");
                wasThereAnError = true;

                throw new ArgumentOutOfRangeException(message: "There was an index out of range.", innerException: ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
                wasThereAnError = true;
            }
            finally
            {
                if (wasThereAnError)
                {
                    result = week[week.Length - 1];
                }
                Console.WriteLine("I am done.");
            }

            return result;
        }

        #endregion
    }
}
