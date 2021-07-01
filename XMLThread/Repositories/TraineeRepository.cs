using System.Collections.Generic;
using XMLThread.Models;

namespace XMLThread.Repositories
{
    public class TraineeRepository : ITraineeRepository
    {
        public List<Trainee> GetAll() 
            => new List<Trainee>
            {
                new Trainee{Name="Reema",University="Imam Abdulrahman bin Faisal University",Major="Computer Science"},
                new Trainee{Name="Hanan",University="Umm Alqura University",Major="Computer Science"},
                new Trainee{Name="Fahad",University="Technology College", Major="Computer Science"},
                new Trainee{Name="Sultan",University="Jubail College", Major="Computer Science"},
                new Trainee{Name="Abdullah",University="Florida STEM University", Major="Computer Science"}
            };

    }
}
