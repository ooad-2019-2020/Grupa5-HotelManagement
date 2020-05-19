using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class StateSlobodna : IState
    {
        private Soba Soba;

        public StateSlobodna(Soba soba)
        {
            this.Soba = soba;
        }

        public Soba DajObjekat()
        {
            return Soba;
        }
    }
}
