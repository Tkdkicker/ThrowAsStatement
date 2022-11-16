using System;

namespace ThrowAsStatement
{
    public class Program
    {
        private static void Main()
        {
            var gen = new Throw();
            int index = 10;

            try
            {
                int value = gen.GetNumber(index);
                Console.WriteLine($"Retrieved {value}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.GetType().Name}: {index} is outside the bounds of the array");
            }
        }
    }
    // The example displays the following output:
    //        IndexOutOfRangeException: 10 is outside the bounds of the array
}