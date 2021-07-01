using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

using System.IO;
using System.Xml.Serialization;


namespace XMLThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Reema = new Student("Reema","Imam Abdulrahman bin Faisal University", "Computer Science");
            SerializeToXml(typeof(Student), Reema, @"C:\Users\Reema\Desktop\StudentInfo.xml");
        }


        static async Task<List<Student>> XMLRead(Type type, string path)
        {
            List<Student> students = null;

            if (File.Exists(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                TextReader reader = new StreamReader(path);
                students = xmlSerializer.Deserialize(reader) as List<Student>;
                reader.Close();
            }

            List<Student> students = null;

            if (File.Exists(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                TextReader reader = new StreamReader(path);
                students = xmlSerializer.Deserialize(reader) as List<Student>;
                reader.Close();
            }

            return null;
        }
        static async Task<List<Student>> GetStudentList()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="Abdullah",Age=28},
                new Student{Id=2,Name="Sultan",Age=24},
                new Student{Id=3,Name="Fahad",Age=27},
                new Student{Id=4,Name="Reema",Age=25},
                new Student{Id=5,Name="Hanan",Age=22}
            };
            return null;
        }
        
    }

    public class Student
    {

        public Student()
        {
                
        }

        public Student(string name, string university, string major)
        {
            Name = name;
            University = university;
            Major = major;
        }

        public string Name { get; set; }
        public string University{ get; set; }
        public string Major { get; set; }
    }
}
