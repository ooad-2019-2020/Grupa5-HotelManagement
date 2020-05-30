using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Korisnik : IdentityUser
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Ime")]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Prezime")]
        public string Prezime { get; set; }


        //user već ima atribut PhoneNumber
        //atribut posao koji je povezan sa tabelom posao za zaposlenika
        //atribut account za korisnika iz tabele account(potrebno je napraviti)
    }
}
