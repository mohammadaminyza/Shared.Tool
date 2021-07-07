using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Convertors
{
    public static partial class StringEditor
    {
        /// <summary>
        /// این متد فاصله های اضافه را حذف و به حروف کوچک تبدیل میکند
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ConvertStringToStandard(this string text)
        {
            var standardText = text.ToLower().Trim();

            return standardText;
        }

        public static string ConvertStringToUrl(this string text)
        {
            var url = text.ConvertStringToStandard().Replace(" ", "-");

            return url;
        }

        public static string ConvertBackStringToUrl(this string url)
        {
            var text = url.Replace("-", " ");

            return text;
        }
    }
}
