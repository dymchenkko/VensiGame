
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vensi
{
    class GraphicCard:Card
    {
        public delegate void Sum(int points);
        public PictureBox Pb { get; set; }
        public bool IsSelected { get; set; }
        private Sum ShowSum;

        public GraphicCard(CardFigure figure, CardSuit suit) : base(figure, suit)
        {
            Form f = new Form();
            
            IsSelected = false;
            Pb = new PictureBox();
            Pb.Tag = "CardFigure."+figure;
            Pb.Click += Pb_click_handler;
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
        private void Pb_click_handler(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string s = pb.Tag.ToString();
            if (IsSelected)
            {
            pb.BorderStyle = BorderStyle.None;
                IsSelected = false;
                ShowSum(VensiValue(s)*-1);
            }
            else
            {
                pb.BorderStyle = BorderStyle.Fixed3D;
                IsSelected = true;
                int index = s.IndexOf(" ");
                
                ShowSum(VensiValue(s));
            }
        }
    }
}
