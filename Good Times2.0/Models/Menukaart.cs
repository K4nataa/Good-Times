using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Good_Times2._0.Models
{
    public class Menukaart
    {        public int Id { get; set; }
        public string Naam { get; set; }
        public int MenuKaartId { get; set; }

        public List<MenuCategory> MenuCategories { get; set; }
    }
}
