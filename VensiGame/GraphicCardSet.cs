using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VensiGame
{
    class GraphicCardSet:CardSet
    {
        public Panel Panel { get; set; }
        //public PictureBox Picturebox { get; set; }

        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }
        public GraphicCardSet(Panel panel,List<Card> card) : base(card)
        {
            Panel = panel;
          
        }
        //public GraphicCardSet(PictureBox pb)
        //{
        //    Picturebox = pb;
        //}

        public GraphicCardSet(Panel panel, int count) : this(panel)
        {
            foreach (var figure in Enum.GetValues(typeof(CardFigure)))
            {
                foreach (var suit in Enum.GetValues(typeof(CardSuit)))
                {
                    Cards.Add(new GraphicCard((CardFigure)figure, (CardSuit)suit));
                }
            }
           if (count < Count)
               Cards.RemoveRange(0, Count - count);
        }

        public override void Show()
        {
            //if (Picturebox != null)
            //{
            //    GraphicCard gc = (GraphicCard)Cards.Last();
            //    gc.Pb = Picturebox;
            //    gc.Show();
            //}
            //else
            //{
                for (int i = 0; i < Cards.Count; i++)
                {
                    GraphicCard graphicCard = (GraphicCard)Cards[i];
                    PictureBox pb = graphicCard.Pb;
                    Panel.Controls.Add(pb);
                    pb.BringToFront();
                    pb.Location = new Point(i * 50, 0);
                    pb.Size = new Size(Panel.Width / Cards.Count, Panel.Height);
                    pb.Image = new Bitmap(pb.Width, pb.Height);
                    pb.TabIndex = i;
                    pb.TabStop = false;

                    graphicCard.Show();
                }

            //}
        }
    }

}
