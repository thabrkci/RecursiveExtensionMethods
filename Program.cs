using System;

namespace RecursiveExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Welcome to Methods ###");

            // Recursive Method
            // 3^4 = 3 * 3 * 3 * 3
            int result = Power(3, 4);
            Console.WriteLine(result);

            // Extension Method Example
            SampleClass sampleObject = new SampleClass();
            sampleObject.DisplayMessage();
        }

        // Recursive Method to calculate the power of a number
        static int Power(int baseNumber, int exponent)
        {
            if (exponent < 2)
                return baseNumber;

            return Power(baseNumber, exponent - 1) * baseNumber;
        }
    }

    // Sample class for extension method demonstration
    public class SampleClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sample class method.");
        }
    }

    // Extension Method Class (if you decide to add extension methods)
    public static class ExtensionMethods
    {
        // Example of an extension method
        // You can add extension methods to existing classes without modifying them.
        public static void ExtendedMethod(this SampleClass obj)
        {
            Console.WriteLine("This is an extension method.");
        }
    }
}
