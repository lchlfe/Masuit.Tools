using Masuit.Tools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Tree
{
    public class TreeExtensionsTest
    {
        [Fact]
        public void Filter()
        {
            var data = new Stu()
            {
                Id = 1,
                Name = "水果",
                Children = new List<Stu> { new Stu() { Id = 11, Name = "苹果" }, new Stu() { Id = 12, Name = "香蕉" } }
            };

            var list = data.Filter(c => c.Id == 12).ToList();
        }

        [Fact]
        public void Filter1()
        {
            var list = new List<Stu>
            {
               new Stu {
                    Id = 1,
                Name = "水果",
                Children = new List<Stu> { new Stu() { Id = 11, Name = "苹果" }, new Stu() { Id = 12, Name = "香蕉" } }
               },
                 new Stu {
                    Id = 2,
                Name = "植物",
                Children = new List<Stu> { new Stu() { Id = 21, Name = "松树" }, new Stu() { Id = 22, Name = "柳树" } }
               },
            };

            var children = list.Flatten((obj1, obj2) => { obj1.Id = 1; obj2.Id = 11; }).ToList();


            var data = list.Filter(c => c.Id == 21).ToList();
        }
        [Fact]
        public void Tree1()
        {
            var node = new Tree<string>("")
            {
                Value = "1",
                Parent = "0",
                Children = new List<Tree<string>>
                {
                    new Tree<string>(""){ Value = "12"},
                    new Tree<string>(""){ Value = "13"}
                }
            };
            var list = node.Filter(c => c.Value == "12").ToList();

        }

        public void Tree2()
        {
            var model = new List<Sco>() {
                new Sco() { Name = "12", Parent = new Sco { Name = "1" } },
                new Sco() { Name = "11", Parent = new Sco { Name = "1" } }
            };

            // var list = model.ToTree(c => { c.Name = "11"; }) ;


        }


    }

    public class Sco : ITree<Sco>
    {
        public string Name { get; set; }
        public Sco Parent { get; set; }
        public ICollection<Sco> Children { get; set; }
    }


    public class Stu : ITreeChildren<Stu>
    {
        public int Id { get; set; }



        public string Name { get; set; }
        public ICollection<Stu> Children { get; set; }
    }
}
