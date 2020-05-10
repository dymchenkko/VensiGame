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

        private void btn_C(object sender, EventArgs e)
        { 
            try
            {
                Button b = (Button)sender;
                if (b.Text == "Забрать колоду")
                {
                    game.IsPlayerGetCardSet = 1;
                }
                else
                {
                    game.IsPlayerGetCardSet = 2;
             
                }
            }
            catch (Exception ex)
            {
            
            }
                    
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btn_move.Visible = true;
            btn_get.Visible = true;
            button1.Visible = false;
            Player[] players = { new Player("Lisa"), new Player("Lisa2") };
             game = new Vensi(pb_curcard, player_pannel, new GraphicCardSet(player_pannel, 52), players);
            game.RegisterHandler(ShowMessage, SetText, SetTime);
            game.Start();
        }
    }
}
