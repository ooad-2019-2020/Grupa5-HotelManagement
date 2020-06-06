using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Rezervacija
    {
        [Key]
        public int RezervacijaId { get; set; }



        [Required(ErrorMessage = "Morate dodati korisnika koji rezerviše")]
        [Display(Name = "Gost")]
        [ForeignKey("Korisnik")]
        public string KorisnikId { get; set; }

        [Display(Name = "Gost")]
        public virtual Korisnik Korisnik { get; set; }




        [Required(ErrorMessage = "Morate dodati sobu koja se rezerviše")]
        [Display(Name = "Rezervisana soba")]
        [ForeignKey("Soba")]
        public int SobaId { get; set; }

        [Display(Name = "Rezervisana soba")]
        public virtual Soba Soba { get; set; }

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


        [Display(Name = "Rezervacija validna")]
        public bool Validnost { get; set; }
    }
}
