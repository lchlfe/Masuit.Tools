using Masuit.Tools.DateTimeExt;
using Masuit.Tools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test
{
    public class DateTimeHelperTest
    {
        [Fact]
        public void GetWeekAmount()
        {
            var res = DateTime.Now.GetWeekAmount(2023);
            Console.WriteLine(res);
        }
        [Fact]
        public void WeekOfYear()
        {
            var num1 = DateTime.Now.WeekOfYear();
            var num2 = DateTime.Now.WeekOfYear(DayOfWeek.Monday);
        }
        [Fact]
        public void GetWeekTime()
        {
            DateTime str1, str2;
            DateTime.Now.GetWeekTime(2023, 10, out str1, out str2);
        }
        [Fact]
        public void GetWeekWorkTime()
        {
            DateTime str1, str2;
            DateTime.Now.GetWeekWorkTime(2023, 10, out str1, out str2);
        }

        [Fact]
        public void GetWeekNameOfDay()
        {
            var time = DateTime.Now.GetWeekNameOfDay();
        }
        [Fact]
        public void ReturnDateFormat()
        {
            string str1, str2;
            DateTime.Now.ReturnDateFormat(2, out str1, out str2);
        }
        [Fact]
        public void GetDateString()
        {
            var s = DateTime.Now.GetDateString();
        }
        [Fact]
        public void GetUnionSet()
        {
            var range = new DateTimeRange(DateTime.Parse("2020-8-3"), DateTime.Parse("2020-8-5"));
            range.Union(DateTime.Parse("2020-8-4"), DateTime.Parse("2020-8-6")); //连接两个时间段，结果：2020-8-3~2020-8-6
            range.In(DateTime.Parse("2020-8-3"), DateTime.Parse("2020-8-6"));//判断是否在某个时间段内，true
            var (intersected, range2) = range.Intersect(DateTime.Parse("2020-8-4"), DateTime.Parse("2020-8-6"));//两个时间段是否相交，(true,2020-8-3~2020-8-4)
            range.Contains(DateTime.Parse("2020-8-3"), DateTime.Parse("2020-8-4"));//判断是否包含某个时间段，true

            range.GetUnionSet(new List<DateTimeRange>()); // 根据某个时间段查找在某批时间段中的最大并集
            range.GetMaxTimePeriod(new List<DateTimeRange>()); // 获取一批时间段内存在相互重叠的最大时间段
        }

    }


}
