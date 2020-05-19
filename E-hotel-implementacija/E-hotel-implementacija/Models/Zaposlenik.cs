using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Zaposlenik : Osoba
    {
        public int PosaoId { get; set; }

        public virtual Posao Posao { get; set; }


        public Zaposlenik(string ime, string prezime, string eMail, string username, string password, Posao posao)
        {
            Ime = ime;
            Prezime = prezime;
            EMail = eMail;
            Username = username;
            Password = password;
            Posao = posao;
        }

        public override object Clone()
        {
            return new Zaposlenik(this.Ime,this.Prezime, this.EMail,this.Username, this.Password,this.Posao);
        }
    }
}
