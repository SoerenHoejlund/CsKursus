using System;
using System.Collections.Generic;
using System.Text;

namespace App19Udvid
{
    public class UdvidetRandom : Random
    {
     
        public bool NextBool()
        {
            //Random rnd = new Random();
            //bool vaerdi;
            //if (rnd.Next(1,1002) <= 500)
            //{
            //    vaerdi = true;
            //}
            //else
            //{
            //    vaerdi = false;
            //}
            //return vaerdi;
            if(this.Next(1,1002) <= 500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
