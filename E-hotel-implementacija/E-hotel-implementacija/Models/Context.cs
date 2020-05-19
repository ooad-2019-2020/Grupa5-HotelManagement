using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class Context
    {
        private IState state;

        public Context(IState state)
        {
            this.state = state;
        }

        public void ChangeState(IState state)
        {
            this.state = state;
        }

        public Soba DajObjekat()
        {
            return state.DajObjekat();
        }
    }
}
