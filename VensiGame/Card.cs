using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vensi
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

        public int VensiValue()
        {
            switch (cardFigure)
            {
                case CardFigure.two:
                    return 2;
                case CardFigure.three:
                    return 3;
                case CardFigure.four:
                    return 4;
                case CardFigure.five:
                    return 5;
                case CardFigure.six:
                    return 6;
                case CardFigure.seven:
                    return 7;
                case CardFigure.eight:
                    return 8;
                case CardFigure.nine:
                    return 9;
                case CardFigure.ten:
                    return 10;
                case CardFigure.jack:
                    return 11;
                case CardFigure.queen:
                    return 12;
                case CardFigure.king:
                    return 13;
                case CardFigure.ace:
                    return 1;
                default:
                    return 0;
            }
        }

            public int VensiValue(string s)
            {
            switch (s)
            {
                case "CardFigure.two":
                    return 2;
                case "CardFigure.three":
                    return 3;
                case "CardFigure.four":
                    return 4;
                case "CardFigure.five":
                    return 5;
                case "CardFigure.six":
                    return 6;
                case "CardFigure.seven":
                    return 7;
                case "CardFigure.eight":
                    return 8;
                case "CardFigure.nine":
                    return 9;
                case "CardFigure.ten":
                    return 10;
                case "CardFigure.jack":
                    return 11;
                case "CardFigure.queen":
                    return 12;
                case "CardFigure.king":
                    return 13;
                case "CardFigure.ace":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
