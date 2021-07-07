using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Calculator
{
    public static partial class PercentCalculator
    {
        /// <summary>
        /// This Method Return Off To Price
        /// این متد مبلغ تخفیف را برمیگرداند
        /// </summary>
        /// <returns></returns>
        public static int CalculatePercentToPrice(this int price, int percent)
        {
            var offPrice = (price * percent) / 100;

            return offPrice;
        }

        /// <summary>
        /// این متد مبلغ را منهای درصد میکند
        /// </summary>
        /// <param name="price"></param>
        /// <param name="percent"></param>
        /// <returns></returns>

        public static int MinesPercentOfPrice(this int price, int percent)
        {
            var offPrice = price.CalculatePercentToPrice(percent);

            var minesPrice = price - offPrice;

            return minesPrice;
        }

        /// <summary>
        ///  این متد مبلغ را به اضافه درصد میکند
        /// </summary>
        /// <param name="price"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        public static int SumPercentOfPrice(this int price, int percent)
        {
            var offPrice = price.CalculatePercentToPrice(percent);

            var sumPrice = price + offPrice;

            return sumPrice;
        }
    }
}
