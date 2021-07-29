using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tunr.Models
{
    public class User
    {
        // Properties
        public int ID { get; set; } // PK
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        // Navigation properties
        public ICollection<Mixtape> Mixtapes { get; set; }
    }
}
