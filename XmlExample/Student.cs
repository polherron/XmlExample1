using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlExample
{
    class Student : Person
    {
        public string course { get; set; }

        public Student()
        {

        }

        public Student(int ID, string fName, string lName, string genger, string address1, string address2, string pCode, string Course) : base(ID, fName, lName, genger, address1, address2, pCode)
        {
            this.course = course;
        }
    }
}
