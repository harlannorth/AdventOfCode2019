using ChallengeOne.InputLoader;
using System;

namespace ChallengeOne
{
    class Program
    {
        private const int divisor = 3;
        private const int subtract = 2;

        static void Main(string[] args)
        {
            
            if (args == null || args.Length == 0)
            {
                throw new Exception("No file to load.");
            }

            Console.WriteLine(args[0]);

            IInputLoader loader = new Loader();
            var inputs = loader.LoadFile(args[0]);

            if (inputs == null)
                throw new Exception("Parsed file returned no input");

            int result = 0;
            foreach(var mass in inputs)
            {
                var dividedMass = (int)(mass / divisor) - subtract;
                result += dividedMass;
            }

            Console.WriteLine(result);
        }
    }
}
