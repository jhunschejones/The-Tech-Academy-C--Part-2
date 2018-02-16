using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool Double { get; set; }
        public bool Tripple { get; set; }
        private Random _random;

        public Dart (Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0,21);
            int chance = _random.Next(1, 101);
            if (chance > 95)
            {
                Tripple = true;
            } else if (chance > 90 && chance < 96)
            {
                Double = true;
            }
        }

    }
}

/*
CONSTRUCTOR METHOD
When creating a new instance of Dart, you will pass it an instance of the System.Random
class to ensure you get a true random number across the lifetime of the web page's 
lifecycle.  

THROW METHOD
When you call the Throw() method it will simulate the act of throwing a 
dart at a dart board.  

The dart has an equal chance of scoring one through twenty,
or the bullseye (0).  For numbers 1 through 20, the dart has a five percent chance 
of landing in the outer band that represents a double score, and a five percent 
chance of landing in the inner band that represents a triple score.  

For the bullseye (number 0) only has an outer ring and the inner bullseye.  There's
only a five percent chance that the inner bullseye can be hit.

The Throw() method should populate properties representing the score, and whether 
it landed in a double or triple band (or outer / inner bullseye).
*/
