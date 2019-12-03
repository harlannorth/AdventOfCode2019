using ChallengeTwo.InputLoader;
using System;

namespace ChallengeTwo
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

            int fuelNeeded = 0;
            foreach(var mass in inputs)
            {
                var dividedMass = GetModuleFuel(mass);
                fuelNeeded += dividedMass;
            }

            Console.WriteLine(fuelNeeded);
        }

        static private int GetModuleFuel(int initialMass)
        {
            var dividedMass = (int)(initialMass / divisor) - subtract;
            if (dividedMass <= 0)
            {
                return 0;
            }

            return dividedMass + GetModuleFuel(dividedMass);

        }
    }
}
