using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkoleKonsoll
{
    internal class VerdiTyper
    {
        //int number = 3;
        //long longerNumber = 992923496035;

        //double whoGivesF = 428.97;
        //float givesSingleF = 428.97F;
        //decimal veryFingAccurate = 428.97M;

        //string keepItPeeGee = "PG";
        //char justPee = 'P';

        //bool passesVibeCheck = false;

        public static decimal AddDifferentNumberTypes()
        {
            int a = 4;
            decimal b = 3.4M;

            decimal sum = Convert.ToDecimal(a) + b;
            return sum;
        }

    }
}
