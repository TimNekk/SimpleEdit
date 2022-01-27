using System;

namespace Space
{
    public class Test
    {
        public static void Main(string[] args)
        {
            int index = 10;
            string text = "Test string with index " + index;

            double[] floatArray = new double[]
            {
                1.2,
                8.3,
                9.4
            };

            foreach (var item in floatArray)
            {
                var result = Print(item + " is text of " + text);
                
                if (result) break;
            }

            Console.ReadKey();
        }

        private static bool Print(string output)
        {
            if (output != "")
            {
                Console.WriteLine(output);
                return true;
            }

            return false;
        }
    }
}