using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    //i ovo bitrebala biti apstraktna klasa
    public class Zaposlenik:Osoba
    {
        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime, string eMail, string username, string password)
        {
            Ime = ime;
            Prezime = prezime;
            EMail = eMail;
            Username = username;
            Password = password;
        }

        public override object Clone()
        {
            return new Zaposlenik(this.Ime,this.Prezime, this.EMail,this.Username, this.Password);
        }
    }
}
