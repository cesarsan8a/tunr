using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tunr.Models
{
    public class Mixtape
    {
        // Properties
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }

        // Navigation properties
        public User User { get; set; }
    }
}
