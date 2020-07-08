using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_By
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public int BuildingId { get; set; }

        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Manager: " + Manager);
            Console.WriteLine("BuildingId: " + BuildingId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department[] departments = {
                new Department { Id=1, Name = "Accounting", Manager = "User1", BuildingId = 15},
                new Department { Id=2, Name = "Sales", Manager = "User2", BuildingId = 3},
                new Department { Id=3, Name = "IT", Manager = "User3", BuildingId = 15},
                new Department { Id=4, Name = "Marketing", Manager = "User4", BuildingId = 3},
            };

            var output = from d in departments
                         group d by d.BuildingId into dp
                         select new { sorted = dp.Key, Department = dp };

            foreach (var item in output)
            {
                Console.WriteLine(item.sorted);
                foreach (var dep in item.Department)
                    dep.Display();
                Console.WriteLine("---------------------------");
            }


        }
    }
}
