using System;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace Assighment
{   //Attributes provide a powerful method of associating metadata, or declarative information, with code. Below is an XML Root Attribute, we have also used XmlAttribute and XmlElement Attribute. 
    [XmlRoot(ElementName = "Employee")]
    //A class is a user-defined blueprint or prototype from which objects are created. Employee class is created below with the fields FirstName, LastName, employeeID and Designation.

    public class Employee
    {        
        private string fName;
        private string lName;
        private int employeeID;
        private string designation;

        [XmlAttribute(AttributeName = "EmployeeID")]
        public int EmployeeID
        {

            get { return employeeID; }
            set { employeeID = value; }
        }

        [XmlElement(ElementName = "FirstName")]
        public string FirstName
        {

            get { return fName; }
            set { fName = value; }
        }

        [XmlElement(ElementName = "LastName")]
        public string LastName
        {

            get { return lName; }
            set { lName = value; }
        }

        [XmlElement(ElementName = "Designation")]
        public string Designation
        {

            get { return designation; }
            set { designation = value; }
        }
         //A method is a code block that contains a series of statements.  The Main method is the entry point for every C# application and it's coded below.
        static void Main(string[] args)
        {
            
            // Object, in C#, is an instance of a class that is created dynamically. An object emp1 is instantiated below.
            Employee emp1 = new Employee();
            Console.Write("Enter EmployeeId =");
            emp1.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter First Name =");
            emp1.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name =");
            emp1.LastName = Console.ReadLine();
            Console.Write("Enter Designation =");
            emp1.Designation = Console.ReadLine();
            //2 Dimensional array
            String[,] example_employee_info = new string[2,4] { { "Sourav", "Patteri", "1234", "Programmer"}, { "John", "Doe", "1221", "Manager" } };

            StreamWriter writer = File.CreateText(@"C:\Users\soura\OneDrive - Georgian College\Desktop\GEORGIAN\C#\employee.Xml");
            XmlSerializer x = new XmlSerializer(typeof(Employee));

            x.Serialize(writer, emp1);
            writer.Close();
           
            
            Employee emp2 = new Employee();
            StreamReader reader = File.OpenText(@"C:\Users\soura\OneDrive - Georgian College\Desktop\GEORGIAN\C#\employee.Xml");
            XmlSerializer x = new XmlSerializer(typeof(Employee));
            
            emp2 = (Employee)x.Deserialize(reader);
            reader.Close();
           
            Console.WriteLine(" Employee First Name:" + emp2.FirstName);
            Console.WriteLine(" Employee Last Name:" + emp2.LastName);
            Console.WriteLine(" Employee ID:" + emp2.EmployeeID);
            Console.WriteLine(" Employee Desigination:" + emp2.Designation);
            Console.ReadLine();
        }
    }
}