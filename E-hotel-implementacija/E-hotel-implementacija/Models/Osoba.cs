using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public abstract class Osoba : ICloneable
    {
        [Key]
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string EMail { get; set; }

        //da li ovo treba, ako već ima kroz login
        //kako modificirati default sign in i log in, tj da se pri sign in upisuju dodatni podaci poput imena, prezimena...
        //Kako implementirati da se u zavisnosti od login podataka otvara drugačiji view

        public string Username { get; set; }

        public string Password { get; set; }

        public abstract object Clone();
    }
}
