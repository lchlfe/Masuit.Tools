using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Extensions
{
    public class DoubleExtensionsTest
    {
        [Fact]
        public void ToDecimal()
        {
            Double num1 = 123.126;
            var num = num1.ToDecimal(2);
        }
    }
}
