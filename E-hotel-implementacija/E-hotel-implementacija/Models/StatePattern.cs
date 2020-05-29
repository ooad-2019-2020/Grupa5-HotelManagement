using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_hotel_implementacija.Models
{
    public class StatePattern
    {
        [Key]
        public int StatePaternId { get; set; }

        private IState state;

        public StatePattern()
        {
            state = new StateSlobodna(null);
        }

        public StatePattern(IState state)
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
