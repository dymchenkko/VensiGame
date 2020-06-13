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
        Player mover;
        public MainForm(String[] names)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);

            List<Player> players = new List<Player>();
            for (int i = 0; i < names.Length; i++)
            {
                Panel pun = new Panel();
                pun.Location = new Point(13, 370);
                pun.Width = 830;
                pun.Height = 200;
                pun.Visible = false;
                this.Controls.Add(pun);
                players.Add(new Player(names[i], new GraphicCardSet(pun)));
            }
            game = new Vensi(players.ToArray(), new GraphicCardSet(Deck_pannel, 52), new GraphicCardSet(panel1));
            game.RegisterHandler(ShowMessage);
            game.SelectCurrentPlayer = MarkPlayer;
            game.RequiredScore = RequiredScore;
            foreach (var card in game.Deck.Cards)
            {
                
                PictureBox cardPictureBox = ((GraphicCard)card).Pb;
                cardPictureBox.Click += CardPictureBox_Click;
               
            }
            game.Start() ;
            int score = game.VensiValue(game.Table.Cards[game.Table.Cards.Count - 1]);
            int min_score = score - 1;
            int max_score = score + 1;
            lbl_score.Text = "Одной картой:" + score;
            lbl_score2.Text = "Двумя или более картами:" + max_score + " или " + min_score;





        }

        private void RequiredScore(int score)
        { 
            int min_score = score - 1;
            int max_score = score + 1;
            lbl_score.Text = "Одной картой:" + score;
            lbl_score2.Text = "Двумя или более картами:" + max_score + " или " + min_score;
        }

        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            
            SetActiveCard(pictureBox);
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                            cur_score.Text = game.Value(Activecards).ToString();
                            mover = null;
                            return;
                            }
                        }
                            Activecards.Add(card);
                        if (game.Table.Cards.Count != 0)

                        {
                            int score = game.VensiValue(game.Table.Cards[game.Table.Cards.Count - 1]);
                            int min_score = score - 1;
                            int max_score = score + 1;
                            lbl_score.Text ="Одной картой:"+score;
                            lbl_score2.Text= "Двумя или более картами"+max_score+ " или " + min_score;

                        }
                        pictureBox.Top += 10;
                        cur_score.Text = game.Value(Activecards).ToString();
                        mover = player;
                       // label1.Text = game.Value(mover.Cards).ToString();??
                        return;
                    }
                }
            }
        }
        private void MarkPlayer(Player activePlayer)
        {           
            
             ((GraphicCardSet)game.CurrentPlayer.Cards).Panel.Visible = false;

           
            game.Refresh();
            if (game.Deck.Cards.Count==0 && game.Table.Cards.Count==0)
            {
                ((GraphicCardSet)game.Table
                   ).Panel.Controls.Clear();
            }
            lbl_Active.Text = "Сейчас ходит:" + game.CurrentPlayer.Name;
            cur_score.Text = game.Value(Activecards).ToString();
            ((GraphicCardSet)game.CurrentPlayer.Cards).Panel.Visible = true;
            Activecards = new CardSet();
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
