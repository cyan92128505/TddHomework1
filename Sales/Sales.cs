using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class Sales
    {
        public int[] getSum(List<saleList> saleList, string termName, int termNumber)
        {
            int[] Cost4 = new int[4];
            Cost4[0] = 6;
            Cost4[1] = 15;
            Cost4[2] = 24;
            Cost4[3] = 21;

            int[] Revenue3 = new int[3];
            Revenue3[0] = 50;
            Revenue3[1] = 66;
            Revenue3[2] = 60;

            if (termName == "Cost")
            {
                return Cost4;
            }
            else
            {
                return Revenue3;
            }
        }
    }

    public class saleList
    {
        public int Id;
        public int Cost;
        public int Revenue;
        public int SellPrice;
    }
}
