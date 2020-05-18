using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class StateSlobodna : IState
    {
        private Soba soba;

        public StateSlobodna(Soba soba)
        {
            this.soba = soba;
        }

        public Soba DajObjekat()
        {
            return soba;
        }
    }
}
