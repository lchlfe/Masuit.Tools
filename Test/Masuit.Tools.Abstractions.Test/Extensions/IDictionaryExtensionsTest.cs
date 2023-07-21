using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Extensions
{
    public class IDictionaryExtensionsTest
    {
        [Fact]
        public void AddOrUpdate()
        {
            var div = new Dictionary<string, object>();
            div.Add("a", 1);
            var div1 = new Dictionary<string, object>();
            div1.Add("b", 2);
            div.AddOrUpdate(div1);


            var list = new List<string>()
            {
                "1","3","3","3"
            };
            var dic = list.ToDictionarySafety(s => s, s => s.GetHashCode());

            dic.AddOrUpdate(new Dictionary<string, int>()
            {
                ["5"] = 5,
                ["55"] = 555
            }); // 批量添加或更新键值对
            dic.AddOrUpdate("5", 6, (s, i) => 66); // 如果是添加，则值为6，若更新则值为66
            dic.AddOrUpdate("5", 6, 666); // 如果是添加，则值为6，若更新则值为666
            dic.GetOrAdd("7", 77); // 字典获取或添加元素
            dic.GetOrAdd("7", () => 77); // 字典获取或添加元素
            dic.AsConcurrentDictionary(); // 普通字典转换成并发字典集合

        }
    }
}
