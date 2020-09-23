using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Good_Times2._0.Models
{
    public class Klant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Telefoonnummer { get; set; }


        public List<Reservering> Reserverings { get; set; }
    }
}
