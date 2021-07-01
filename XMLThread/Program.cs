using System;
using System.Threading.Tasks;
using System.Collections.Generic;

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


        static void SerializeToXml(Type type, object o, string path)
         {
            if (File.Exists(path)) File.Delete(path);
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            TextWriter writer = new StreamWriter(path);
            xmlSerializer.Serialize(writer, o);
            writer.Close();
         }

        static object DeserializeFromXml(Type type, string path)
            {

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

            return null;
        }
        static async Task<List<Student>> GetStudentList()
        {

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
