using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Context
    {
        private IState state;
        private Soba objekat;

        public Context(IState state, Soba objekat)
        {
            this.state = state;
            this.objekat = objekat;
        }

        public void changeState(IState state)
        {
            this.state = state;
        }

        public Soba DajObjekat()
        {
            return state.DajObjekat();
        }
    }
}
