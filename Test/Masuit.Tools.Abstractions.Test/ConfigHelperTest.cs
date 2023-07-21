using Masuit.Tools.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test
{
    public class ConfigHelperTest
    {
        [Fact]
        public void GetConfigOrDefault()
        {
            var value= ConfigHelper.GetConfigOrDefault("stu:name");
            Console.WriteLine(value);
        }
    }
}
