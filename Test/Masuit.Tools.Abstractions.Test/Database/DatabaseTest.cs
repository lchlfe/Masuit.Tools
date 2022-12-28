using Masuit.Tools.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Database
{
    public class DatabaseTest
    {

        [Fact]
        public void ToObject()
        {
            DataTable dt = new DataTable("Stu");

            dt.Columns.Add("Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Age", System.Type.GetType("System.String"));

            DataRow dr = dt.NewRow();
            dr["Name"] = "张三";
            dr["Age"] = "12";
            dt.Rows.Add(dr);


            var list = DataTableHelper.ToList<Stu>(dt);
            Console.WriteLine(12345);
        }

        [Fact]
        public void ToTable()
        {
            var list = new List<Stu>() {

                new Stu{ Age="1", Name="张三" },
                new Stu{ Age="2",Name="李四"}
            };

            var aData = DataTableHelper.ToDataTable(list);
            Console.WriteLine(12345);
        }
    }





    public class Stu
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
