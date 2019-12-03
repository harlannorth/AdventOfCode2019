using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ChallengeTwo.InputLoader
{
    internal class Loader : IInputLoader
    {
        public IEnumerable<int> LoadFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileLoadException("File doesn't exist");
            }

            var reader = File.ReadAllLines(fileName);

            var inputs = new List<int>();
            foreach(var line in reader)
            {
                if (int.TryParse(line, out var value))
                {
                    inputs.Add(value);
                }
            }
            return inputs;
        }
    }
}
