using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VensiGame
{
    public partial class MainForm : Form
    {
        Vensi game;

        public MainForm()
        {
            InitializeComponent();
            Player[] players = { new Player("Lisa",new GraphicCardSet(player_pannel)), new Player("Lisa2",new GraphicCardSet(player2_pannel)) };
            game = new Vensi(players, new GraphicCardSet(Deck_pannel, 52), new CardSet());
            game.RegisterHandler(ShowMessage);
            game.Start();
        }

        private void ShowMessage(string message)
        {
            //label?
            MessageBox.Show(message.ToString());
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            game.MoveAction(new MoveActive())
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            game.MoveAction(new MovePassive());
        }
    }
}
