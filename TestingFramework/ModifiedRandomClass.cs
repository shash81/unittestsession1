using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFramework
{
    public class AddToRandomTest
    {
        public IRandomGenerator _generator;
        public AddToRandomTest(IRandomGenerator generateRandom)
        {
            _generator = generateRandom;
        }

        public int add5toRandom()
        {
            return _generator.generateNumber() + 5;
        }
    }
     public interface IRandomGenerator
    {
        int generateNumber();
    }
    public class ModifiedRandomClass : IRandomGenerator
    {
        public int generateNumber()
        {
            return RandomTest.getRandomNumber();
        }
    }
}
