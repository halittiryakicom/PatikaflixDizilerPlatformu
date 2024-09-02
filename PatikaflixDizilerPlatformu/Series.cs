using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaflixDizilerPlatformu
{
    public class Series
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public string Type { get; set; }
        public int PublishYear { get; set; }
        public string Director {  get; set; }
        public string Platform { get; set; }

        public Series(string name, int productionYear, string type, int publishYear, string director, string platform)
        {
            Name = name;
            ProductionYear = productionYear;
            Type = type;
            PublishYear = publishYear;
            Director = director;
            Platform = platform;
        }

    }
}
