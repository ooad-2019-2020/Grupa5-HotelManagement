﻿using Microsoft.AspNetCore.Http;
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

        public string Brojsobe { get; set; }

        public double CijenaSobe { get; set; }

        public double OcjenaSobe { get; set; }

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
