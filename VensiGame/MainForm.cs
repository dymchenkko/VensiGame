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
        CardSet Activecards = new CardSet();
        Card activeCard;
        Player mover;
        public MainForm()
        {
            InitializeComponent();
            Player[] players = { new Player("Lisa",new GraphicCardSet(player_pannel)), new Player("Lisa2",new GraphicCardSet(player2_pannel)) };
            game = new Vensi(players, new GraphicCardSet(Deck_pannel, 52), new GraphicCardSet(pictureBox2));
            game.RegisterHandler(ShowMessage);
            game.SelectCurrentPlayer = MarkPlayer;
            game.Start();
            foreach (var player in game.Players)
            {
                foreach (var card in player.Cards.Cards)
                {
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.Click += CardPictureBox_Click;
                }
               
            }
            

        }
        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            
            SetActiveCard(pictureBox);
           
        }

       
        private void SetActiveCard(PictureBox pictureBox)
        {
            foreach (var player in game.Players)
            {
                foreach (var card in player.Cards.Cards)
                {
                    if (((GraphicCard)card).Pb == pictureBox)
                    {
                        for (int i = 0; i < Activecards.Cards.Count; i++)
                        {
                            if (card == Activecards.Cards[i])
                            {
                                Activecards.Pull(i);
                            pictureBox.Top -= 10;
                            mover = null;
                                return;
                            }
                        }
                            Activecards.Add(card); 
                            pictureBox.Top += 10;
                            mover = player;
                        return;
                    }
                }
            }
        }
        private void MarkPlayer(Player activePlayer)
        {
            foreach (var player in game.Players)
            {
                if (player == activePlayer)
                    ((GraphicCardSet)player.Cards).Panel.Visible = false;
                              else
                    ((GraphicCardSet)player.Cards).Panel.Visible = true;

            }
            game.Refresh();
            
        }

        private void ShowMessage(string message)
        {
            //label?
            MessageBox.Show(message.ToString());
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            game.MoveAction(new MoveActive(Activecards));
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            game.MoveAction(new MovePassive());
           
        }
    }
}
