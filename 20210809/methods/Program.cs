using System;

namespace methods
{
    public class FileService
    {
        public void Create(string path)
        {
            Console.WriteLine("Saving image to {0}", path);
        }

        public void Read(string imageName)
        {
            Console.WriteLine("Reading image {0}", imageName);
        }

        public void Update(string imageName)
        {
            Console.WriteLine("Updating image {0}", imageName);
        }

        public void Delete(string imageName)
        {
            Console.WriteLine("Deleting image {0}", imageName);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");

            foreach(var argument in args) 
            {
                Console.WriteLine(argument);
            }

            Console.WriteLine("End");

        //     #region temp

        //     // ImageService service = new ImageService();
        //     // service.Create("C:\\Users\\Public\\Pictures\\Sample.jpg");
        //     // service.Read("C:\\Users\\Public\\Pictures\\Sample.jpg");

        //     string url = "http://google.com/user/121234123/HOME";
        //     string[] urlParts = url.Split('/');

        //     int ID = 0;
        //     for(var i = 0; i < urlParts.Length; i++)
        //     {
        //         if (urlParts[i] == "user") 
        //         {
        //             var strValue = urlParts[i + 1];
        //             // bool isValid = int.TryParse(strValue, out ID);
        //             bool isValid = TryParsePassByReference(strValue, ID);
        //             Console.Write(isValid);
        //         }

        //         if (urlParts[i] == "HOME") 
        //         {
        //             var strValue = urlParts[i];
        //             bool isValid = TryParseReferenceType(strValue);
        //             Console.WriteLine(isValid);
        //         }
        //     }

        //     Console.WriteLine($"User ID is: {ID}");

        //     // foreach(var str in urlParts) 
        //     // {
        //     //     if (str == "user") {

        //     //     }
        //     // }
        // }

        // #endregion
    
        //     #region Pass By Reference


        //     public static bool TryParseReferenceType(string exampleString)
        //     {
        //         exampleString = exampleString.ToLower();
        //         return true;
        //     }

        //     public static bool TryParsePassByReference(string numberAsString, int result)
        //     {
        //         try
        //         {
        //             result = int.Parse(numberAsString);
        //             return true;
        //         }
        //         catch (Exception ex)
        //         {
        //             result = 0;
        //             Console.WriteLine(ex);
        //             return false;
        //         }
        //     }

        //     public static bool TryParsePassByReference(string numberAsString, out int result) 
        //     {
        //         try
        //         {
        //             result = int.Parse(numberAsString);
        //             return true;
        //         }
        //         catch (Exception ex)
        //         {
        //             result = 0;
        //             Console.WriteLine(ex);
        //             return false;
        //         }
        //     }


        //     #endregion 

        //     #region Overloaded Methods

        //     public static string HelloUser(string name)
        //     {
        //         return $"Hello {name}";
        //     }

        //     public static string HelloUser(string name, string greeting)
        //     {
        //         return $"{greeting}, {name}";
        //     }

        //     #endregion

        //     #region Variable Argument Method

            // public static void PassInUnknownArgs(params string[] value)
            // {
            //     for(int i = 0; i < value.Length; i++)
            //     {
            //         Console.WriteLine(value[i]);
            //     }
            // }

            // #endregion

        }
    }
}
