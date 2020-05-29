using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public abstract class Osoba : IdentityUser, ICloneable
    {
        /*[Key]
        public int Id { get; set; }*/

        [Required]
        [StringLength(50)]
        [Display(Name = "Ime")]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Prezime")]
        public string Prezime { get; set; }

        //public string Email { get; set; }

        //da li ovo treba, ako već ima kroz login
        //kako modificirati default sign in i log in, tj da se pri sign in upisuju dodatni podaci poput imena, prezimena...
        //Kako implementirati da se u zavisnosti od login podataka otvara drugačiji view

        //public string UserName { get; set; }

        //public string Password { get; set; }

        public abstract object Clone();
    }
}
