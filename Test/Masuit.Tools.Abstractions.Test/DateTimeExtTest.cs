
using Masuit.Tools.DateTimeExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Masuit.Tools.Abstractions.Test
{
    public class DateTimeExtTest
    {
        private readonly ITestOutputHelper Output;

        public DateTimeExtTest(ITestOutputHelper output)
        {
            Output = output;
        }


        [Fact]
        public void test1()
        {
            var date = DateTime.Now.GetWeekAmount(2022);
            Output.WriteLine(date.ToString());
        }

        [Fact]
        public void test2()
        {
            var date = DateTime.Now.WeekOfYear();
            Output.WriteLine(date.ToString());
        }
    }
}
