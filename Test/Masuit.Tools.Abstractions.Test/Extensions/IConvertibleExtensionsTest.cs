using SixLabors.ImageSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Extensions
{
    public class IConvertibleExtensionsTest
    {
        [Fact]
        public void IsNumeric()
        {
            Type t = "123".GetType();
            var num1 = t.IsNumeric();
        }

        [Fact]
        public void ConvertTo()
        {
            var num1 = 123.122.ConvertTo<int>();
        }
    }
}
