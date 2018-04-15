using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlExample
{
    class Person
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string gender { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string pCode { get; set; }

        public Person(){ }

        public Person(int ID, string fName, string lName, string genger,
           string address1, string address2, string pCode)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
            this.gender = gender;
            this.address1 = address1;
            this.address2 = address2;
            this.pCode = pCode;
        }
        
    }
}
