using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoulMicroMath
{
    public class PoulMicroMath //Pouls Mathc klasse
    {
       /// <summary>
       /// Lægger to tal sammen
       /// </summary>
       /// <param name="t1">det første tal</param>
       /// <param name="t2">det andet tal</param>
       /// <returns>et heltal der er summen af t1 og t2</returns>
        public int Add(int t1, int t2)
        {
            return t1 + t2;
        }

        public int Add3Numbers(int t1, int t2, int t3)
        {
            return t1 + t2 + t3; //add 3 numbers
        }
    }
}
