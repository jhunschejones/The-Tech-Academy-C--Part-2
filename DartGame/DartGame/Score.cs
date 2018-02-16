using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartGame
{
    public class Score
    {
        public static void DartScore(Player player, Dart dart)
        {
            int score = 0;

            // calculates double or tripple score for normal throw
            if (dart.Tripple)
            {
                score = dart.Score * 3;
            } else if (dart.Double)
            {
                score = dart.Score * 2;
            } else
            {
                score = dart.Score;
            }

            // calculates inner or outer bullseye
            // 0 is bullseye, dart.Double has a 5% chance, used to calculate inner bullseye
            if (dart.Score == 0 && dart.Double) 
            {
                score = 50;
            } else if (dart.Score == 0)
            {
                score = 25;
            }
            player.Score += score;
        }
    }
}