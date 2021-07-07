using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Generators
{
    public static partial class UniqCodeGenerator
    {
        public static string GenerateGuid()
        {
            var code = Guid.NewGuid().ToString().Replace("-", "");

            return code;
        }
    }
}
