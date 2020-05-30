using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class SistemskaGreska
    {
        [Key]
        public int SistemskaGreskaId { get; set; }

        [Display(Name = "Učestalost greške")]
        public int UcestalostGreske { get; set; }

        [Display(Name = "Opis greške")]
        public string OpisGreske { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum kada se greška pojavila")]
        public DateTime Datum { get; set; }
    }
}
