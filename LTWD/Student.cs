using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTWD
{
    internal class Student
    {
        public Student(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public String Phone { get; set; }
    }


}
