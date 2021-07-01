using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLThread.Models
{
    public class Trainee
    {
        public string Name { get; set; }
        public string University { get; set; }
        public string Major { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, University = {University}, Major = {Major}";
        }
    }
}
