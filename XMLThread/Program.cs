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
            Trainee Reema = new Trainee("Reema","Imam Abdulrahman bin Faisal University", "Computer Science");
            XMLWrite(typeof(Trainee), Reema, @"C:\Users\Reema\Desktop\TraineeInfo.xml");
        }


        static void XMLWrite(Type type, object o, string path)
         {
            if (File.Exists(path)) File.Delete(path);
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            TextWriter writer = new StreamWriter(path);
            xmlSerializer.Serialize(writer, o);
            writer.Close();
         }

        static async Task<List<Trainee>> XMLRead(Type type, string path)

        { 

            if (File.Exists(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                TextReader reader = new StreamReader(path);
                students = xmlSerializer.Deserialize(reader) as List<Trainee>;
                reader.Close();
            }

            return null;
        }
        static async Task<List<Trainee>> GetTraineeList()
        {

            List<Trainee> trainees = new List<Trainee>
            {
                new Trainee{Name="Reema",University="Imam Abdulrahman bin Faisal University",Major="Computer Science"},
                new Trainee{Name="Hanan",University="Umm Alqura University",Major="Computer Science"},
                new Trainee{Name="Fahad",University="Technology College", Major="Computer Science"},
                new Trainee{Name="Sultan",University="Jubail College", Major="Computer Science"},
                new Trainee{Name="Abdullah",University="Florida STEM University", Major="Computer Science"}
            };
            return trainees;

        }
        
    }

    public class Trainee
    {

        public Trainee()
        {
                
        }

        public Trainee(string name, string university, string major)
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
