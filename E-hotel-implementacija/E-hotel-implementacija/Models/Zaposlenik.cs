using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Zaposlenik : Osoba
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;

       

        public int PosaoId { get; set; }

        public virtual Posao Posao { get; set; }


        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime, string eMail, string username, int posaoId)
        {
            Ime = ime;
            Prezime = prezime;
            Email = eMail;
            UserName = username;
            PosaoId = posaoId;
        }


        public override object Clone()
        {
            return new Zaposlenik(Ime=this.Ime,Prezime=this.Prezime, Email=this.Email,UserName=this.UserName,PosaoId=this.PosaoId);
        }
    }
}

/* public Zaposlenik(string ime, string prezime, string eMail, string username, string password, int posaoId)
        {
            Ime = ime;
            Prezime = prezime;
            Email = eMail;
            UserName = username;
            Password = password;
            PosaoId = posaoId;
        }

        public override object Clone()
{
    return new Zaposlenik(this.Ime, this.Prezime, this.Email, this.UserName, this.Password, this.PosaoId);
}*/