using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vensi;

namespace VensiGame
{
    class MoveActive: Move
    {
        public MoveActive(CardSet movingCards)
        {
            MovingCards = movingCards;
        }

        public CardSet MovingCards { get; set; }
    }
}
