using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tunr.Models
{
    public class SearchMixtapes
    {
        public IEnumerable<Mixtape> Mixtapes { get; set; }
        public IEnumerable<Mixtape> Tags { get; set; }
        public string tagSearch { get; set; }
        public string titleSearch { get; set; }
    }
}
