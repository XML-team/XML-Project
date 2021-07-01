using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLThread.Models;

namespace XMLThread.Utils
{
    public static class TraineeXmlUtils
    {
        public static async Task<List<Trainee>> XMLReadAll(Type type, string path)
        {
            if (!File.Exists(path)) return null;

            using TextReader reader = new StreamReader(path);
            return (new XmlSerializer(type)).Deserialize(reader) as List<Trainee>;
        }

        public static async Task XMLWriteAll(Type type, List<Trainee> trainees, string path)
        {
            File.Delete(path);

            using TextWriter writer = new StreamWriter(path);
            (new XmlSerializer(type)).Serialize(writer, trainees);
        }
    }
}
