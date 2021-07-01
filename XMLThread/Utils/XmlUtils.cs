using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLThread.Models;

namespace XMLThread.Utils
{
    public static class XmlUtils
    {
        public static async Task<List<Trainee>> XMLReadAll(Type type, string path)
        {
            List<Trainee> trainees = null;

            if (File.Exists(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(type);
                TextReader reader = new StreamReader(path);
                trainees = xmlSerializer.Deserialize(reader) as List<Trainee>;
                reader.Close();
            }

            return trainees;
        }

        public static async Task XMLWriteAll(Type type, List<Trainee> trainees, string path)
        {
            if (File.Exists(path)) File.Delete(path);
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            TextWriter writer = new StreamWriter(path);
            xmlSerializer.Serialize(writer, trainees);
            writer.Close();
        }
    }
}
