using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Soba
    {
        [Key]
        public int SobaId { get; set; }

        [Display(Name = "Redni broj sobe")]
        public string Brojsobe { get; set; }

        [Display(Name = "Cijena sobe po danu u KM")]
        public double CijenaSobe { get; set; }

        [Display(Name = "Ocjena sobe")]
        public double OcjenaSobe { get; set; }

        [Display(Name = "Opis sobe")]
        public string OpisSobe { get; set; }

        [Display(Name = "Slika sobe")]
        public String SlikaSobe { get; set; }

        public StatePattern StatePattern { get; set; }

       
        public void PromijeniStatus(IState state)
        {
            StatePattern.ChangeState(state);
        }

        public Soba DajObjekat()
        {
            return StatePattern.DajObjekat();
        }
    }
}
