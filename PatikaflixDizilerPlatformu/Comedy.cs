using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaflixDizilerPlatformu
{
    public class Comedy
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Director { get; set; }

        public Comedy(string name, string type, string director)
        {
            Name = name;
            Type = type;
            Director = director;
        }
    }
}
