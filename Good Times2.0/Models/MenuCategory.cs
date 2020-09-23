using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Good_Times2._0.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Naam { get; set; }


        public int MenuCategoryId { get; set; }
        public Menukaart Menukaart { get; set; }


        public List<Product> Products { get; set; }
    }
}
