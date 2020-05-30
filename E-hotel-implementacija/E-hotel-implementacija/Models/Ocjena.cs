using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Ocjena
    {
        [Key]
        public int OcjenaId { get; set; }

        [Required]
        [Display(Name = "Ocjena usluge")]
        public int Vrijednost { get; set; }

        [Required]
        [Display(Name = "Opis ocjene")]
        public string Opis { get; set; }
    }
}
