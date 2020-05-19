using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Posao
    {
        [Key]
        public int PosaoId { get; set; }

        public string Naziv { get; set; }

        public double Plata { get; set; }
    }
}
