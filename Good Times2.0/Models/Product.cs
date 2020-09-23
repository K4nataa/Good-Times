using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Good_Times2._0.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public double Prijs { get; set; }


        public int MenuCategoryId { get; set; }
        public MenuCategory MenuCategory { get; set; }
    }
}
