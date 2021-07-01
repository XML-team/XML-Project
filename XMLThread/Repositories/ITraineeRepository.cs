using System.Collections.Generic;
using XMLThread.Models;

namespace XMLThread.Repositories
{
    interface ITraineeRepository
    {
        public List<Trainee> GetAll();
    }
}
