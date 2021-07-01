using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace XMLThread
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static async Task XMLWrite(List<Student> students)
        {
            
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

            return null;
        }

        static async Task<List<Student>> GetStudentList()
        {

            return null;
        }
        
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
