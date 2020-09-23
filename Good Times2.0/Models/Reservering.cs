using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Good_Times2._0.Models
{
    public class Reservering
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Telefoonnummer { get; set; }
        public int AantalPersonen { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Begintijd { get; set; }

        [DataType(DataType.Time)]
        public DateTime Eindtijd { get; set; }


        [DataType(DataType.MultilineText)]
        public string Opmerkingen { get; set; }
        public int opmerkingLimit = 14;
        public string opmerkingTrimmed
        {
            get
            {
                if (this.Opmerkingen.Length > this.opmerkingLimit)
                    return this.Opmerkingen.Substring(0, this.opmerkingLimit) + "...";
                else
                    return this.Opmerkingen;
            }
        }

        [ScaffoldColumn(false)]
        public string MedewerkerId { get; set; }
        public IdentityUser Medewerker { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DatumAangemaakt { get; set; }

        public Reservering()
        {
            DatumAangemaakt = DateTime.Now;

        }
    }
}
