using System.Collections.Generic;

namespace ChallengeTwo.InputLoader
{
    internal interface IInputLoader
    {
        IEnumerable<int> LoadFile(string fileName);
    }
}
