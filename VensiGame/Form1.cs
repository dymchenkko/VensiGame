using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vensi
{
    public partial class Deck : Form
    {
   
        Vensi game;
         public Deck()
         {
            InitializeComponent();
            Player[] players = { new Player("Lisa"), new Player("Lisa2") };
            Vensi game = new Vensi(players, new GraphicCardSet(player_pannel, 52),new CardSet());
            game.RegisterHandler(ShowMessage, SetText, SetTime);
            game.Start();

        }


        private void ShowMessage(string message)
        {
            MessageBox.Show(message.ToString());
        }
        
        private void SetText(int n)
        {
            lbl_score.Text = n.ToString();
        }
        private void SetTime(int n)
        {
            lbl_time.Text = n.ToString();
        }

    }
}
