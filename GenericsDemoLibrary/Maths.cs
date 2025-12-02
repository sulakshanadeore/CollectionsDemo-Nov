using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemoLibrary
{
    public class Maths
    {

        public int DivideNos(int n1, int n2)
        {
            int ans = 0;
            try
            {
                ans = n1 / n2;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return ans;
        }

    }
}
