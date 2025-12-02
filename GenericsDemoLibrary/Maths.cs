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

        public int[] MultiplyNos(int[] arr)
        {
            int[] ans = new int[3];
            try
            {
                if (arr.Length > 3)
                {
                    throw new IndexOutOfRangeException("Array too long");
                 }
                else
                {
                  for (int i = 0; i < 3; i++)
                    {
                        ans[i] = arr[i] * 1000000;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
             //   throw new Exception("Failed to read array, size error",ex);
            }

            return ans;

        }



    }
}
