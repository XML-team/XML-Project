using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XMLThread.Models;
using XMLThread.Repositories;
using XMLThread.Utils;

namespace XMLThread
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await WriteAndReadTraineeData(@"C:\TraineeInfo.xml");
            Console.ReadKey();
        }

        private static async Task WriteAndReadTraineeData(string path)
        {
            Type typeOfTrainee = typeof(List<Trainee>);

            await TraineeXmlUtils.XMLWriteAll(
                typeOfTrainee,
                (new TraineeRepository()).GetAll(), 
                path);

            foreach (var trainee in await TraineeXmlUtils.XMLReadAll(typeOfTrainee, path)) 
                Console.WriteLine(trainee);
        }
    }
}
