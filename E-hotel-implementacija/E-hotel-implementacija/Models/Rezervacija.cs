using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Rezervacija
    {
        [Key]
        public int RezervacijaId { get; set; }

        public Korisnik Gost { get; set; }

        [Display(Name = "Rezervisana soba")]
        public Soba Soba { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum početka boravka")]
        public DateTime DatumPocetka { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum kraja boravka")]
        public DateTime DatumKraja { get; set; }

        [Display(Name = "Popust u procentima")]
        public int Popust { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum rezervacije")]
        public DateTime DatumRezervacije { get; set; }


        [Display(Name = "Redni broj parking mjesta")]
        public int Parking { get; set; }


        [Display(Name = "Validnost rezervacije")]
        public bool Validnost { get; set; }
    }
}
