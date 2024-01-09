using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{

    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {

            //    if (candidate == 1)
            //    {
            //        return false;
            //    }
            //    throw new NotImplementedException("Not implemented.");


            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }

    }

}