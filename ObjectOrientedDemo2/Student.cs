using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDemo2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter the Student for Id");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the student  Name");
            this.Name = Console.ReadLine();

            Console.WriteLine("Please enter the student  Address");
            this.Address = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine(" Id=" + this.Id);
            Console.WriteLine(" Name=" + this.Name);
            Console.WriteLine(" Address=" + this.Address);
        }
    }
}
