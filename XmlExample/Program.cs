using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load(@"..\..\students.xml");
            // ReadXML(xelement);

            //ReadSingleElements(xelement);
            GetFemales(xelement);

            Console.ReadLine();


        }

        private static void GetFemales(XElement xelement)
        {
            var result = from nm in xelement.Elements("record")
                       where (string)nm.Element("Gender") == "Female"
                         select nm;


            List<Student> myStudents = new List<Student>();

            //List<Student> list_course = result.ToList<Student>();

        }

        private static void ReadSingleElements(XElement xelement)
        {
            
            IEnumerable<XElement> employees = xelement.Elements();
            Console.WriteLine("List of all Employee Names :");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Element("FName").Value + " " + employee.Element("LName").Value);
            }
        }

        private static void ReadXML(XElement xelement)
        {
            //XElement xelement = XElement.Load(@"..\..\data\students.xml");
            IEnumerable<XElement> myStudents = xelement.Elements();
            // Read the entire XML
            foreach (var student in myStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
