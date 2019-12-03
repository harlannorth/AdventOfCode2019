using System.Collections.Generic;

namespace ChallengeOne.InputLoader
{
    internal interface IInputLoader
    {
        IEnumerable<int> LoadFile(string fileName);
    }
}
