using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Convertors
{
    public static partial class PriceConvertor
    {
        public static int RialToToman(this int price)
        {
            int toman = price / 10;

            return toman;
        }

        public static int TomanToRial(this int price)
        {
            int rial = price * 10;

            return rial;
        }
    }
}
