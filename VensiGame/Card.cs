using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VensiGame
{
    class Card
    {
        public CardSuit cardSuit { get; set; }
        public CardFigure cardFigure { get; set; }
        public Card( CardFigure cardfigure,CardSuit cardsuit)
        {
            cardSuit = cardsuit;
            cardFigure = cardfigure;
        }
        public virtual void Show()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", this.cardSuit, this.cardFigure);
        }


        
    }
}
