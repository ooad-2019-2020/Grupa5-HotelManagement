using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class StateZauzeta:IState
    {
        private Soba Soba;

        public StateZauzeta(Soba soba)
        {
            this.Soba = soba;
        }

        public Soba DajObjekat()
        {
            return null;
        }
    }
}
