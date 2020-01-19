using System;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace Week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial t = new Tutorial();
            Console.WriteLine(t.TutorialID);
            Console.WriteLine(t.TutorialName);

            Student s = new Student();

            string JSONresult = JsonConvert.SerializeObject(s);
            Console.WriteLine(JSONresult);

            s = JsonConvert.DeserializeObject<Student>(JSONresult);
            Console.WriteLine("ID = " + s.student_id);
            Console.WriteLine("First Name = " + s.first_name);
            Console.WriteLine("Last Name = " + s.last_name);
            Console.WriteLine("Course = " + s.course);
            //use File to save the JSon File at the given path.
            string path = @"C:\Users\soura\OneDrive - Georgian College\Desktop\GEORGIAN\C#\student.json";
            if (File.Exists(path))
            {
                File.Delete(path);
                File.WriteAllText(path, JSONresult);
            }
            else File.WriteAllText(path, JSONresult);
            //use StreamWriter to save the JSon File at the given path.
            //string path2 = @"C:\Users\soura\Desktop\student1.json";
            //using (var tw = new StreamWriter(path2, true))
            //{
              //  tw.WriteLine(JSONresult.ToString());
              //tw.Close();
            //}
        }
    }
}
