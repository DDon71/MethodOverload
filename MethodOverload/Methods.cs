using System;
namespace MethodOverload
{
    internal class Methods
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            var sum = 0;
            var response = "";

            if (z)
            {
                sum = x + y;
                if(sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
            }
            return response;
        }

    

       
    }
}

