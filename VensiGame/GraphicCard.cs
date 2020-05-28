
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VensiGame
{
    class GraphicCard:Card
    {
        public delegate void Sum(int points);
        public PictureBox Pb { get; set; }
        private Sum ShowSum;

        public GraphicCard(CardFigure figure, CardSuit suit) : base(figure, suit)
        {
            Pb = new PictureBox();
            Pb.Tag = "CardFigure."+figure;
            Pb.SizeMode = PictureBoxSizeMode.StretchImage;
            Pb.Width = 50;
            Pb.Height = 100;
        }
        public void RegisterHandler(Sum showSum)
        {
            ShowSum = showSum;
        }
        public GraphicCard(CardFigure cardfigure, CardSuit cardsuit, PictureBox pb):base(cardfigure, cardsuit)
        {
            Pb = pb;
        }
        public override void Show()
        {
            Pb.ImageLocation = "Cards//" + ToString()+".png";
        }
        }
    }
