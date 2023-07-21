using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Extensions
{
    public class BigIntegerExtensionsTest
    {
        [Fact]
        public void ToBase()
        {
            var str = 12345678.ToBase(36);
        }
    }
}
