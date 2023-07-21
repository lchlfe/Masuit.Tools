using Masuit.Tools.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test
{
    public class DataTableHelperTest
    {
        public List<Stu> list = new List<Stu>() { new Stu { Age = 1, Name = "张三" }, new Stu { Age = 2, Name = "李四" } };

        [Fact]
        public void ToDataTable()
        {
            var data = list.ToDataTable();
            Console.WriteLine(data);
        }
        [Fact]
        public void AddIdentityColumn()
        {
            var data = list.ToDataTable();
            data.AddIdentityColumn();
            Console.WriteLine(data);
        }
        [Fact]
        public void HasRows()
        {
            var data = list.ToDataTable();
            var res = data.HasRows();
            Console.WriteLine(res);
        }
        [Fact]
        public void ToList()
        {
            var data = list.ToDataTable();
            var res = data.ToList<Stu>();
            Console.WriteLine(res);
        }
        [Fact]
        public void CreateTable()
        {
            var str = new List<string>() { "age", "name" };
            var data = str.CreateTable();
            Console.WriteLine(data);
        }

        [Fact]
        public void CreateTableStr()
        {
            var data = list.ToDataTable().CreateTable("a,b");
            Console.WriteLine(data);
        }
        [Fact]
        public void GetDataRowArray()
        {
            var data = list.ToDataTable();
            var rows = data.Rows;
            var res = rows.GetDataRowArray();
            Console.WriteLine(res);
        }

        [Fact]
        public void GetTableFromRows()
        {
            var data = list.ToDataTable();
            var rows = data.Rows;
            var res = rows.GetDataRowArray();
            var table = res.GetTableFromRows();
            Console.WriteLine(table);
        }

    }

    public class Stu
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }


}
