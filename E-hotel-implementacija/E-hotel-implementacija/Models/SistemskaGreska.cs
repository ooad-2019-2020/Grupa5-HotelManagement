using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class SistemskaGreska
    {
        [Key]
        public int Id { get; set; }

        public int KodGreske { get; set; }

        public int UcestalostGreske { get; set; }

        public string OpisGreske { get; set; }

        public DateTime Datum { get; set; }
    }
}
