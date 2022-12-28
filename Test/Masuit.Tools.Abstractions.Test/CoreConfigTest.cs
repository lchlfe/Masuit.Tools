using Masuit.Tools.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Masuit.Tools.Abstractions.Test
{

    public class CoreConfigTest
    {


        private readonly ITestOutputHelper Output;

        public CoreConfigTest(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void WriteConfig()
        {
            Output.WriteLine("123456");
            var str = ConfigHelper.GetConfigOrDefault("abc");
            Output.WriteLine(str);
        }
        [Fact]
        public void TT()
        {
            Assert.Equal("2", "2");         
        }
    }
}
