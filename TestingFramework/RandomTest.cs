using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestingFramework
{
    class RandomTest
    {
        public static int getRandomNumber()
        {
            Random num = new Random();
            return num.Next(5, 10);

        }
    }

    public class AddToRandom
    {
        public int add5toRandom()
        {
           return RandomTest.getRandomNumber() + 5;
        }
    }
}
