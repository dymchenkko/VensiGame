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
    public partial class Initial : Form
    {
        TextBox[] tboxes;
        public Initial()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            tboxes = new TextBox[] { playerName1, playerName2, playerName3, playerName4, playerName5, playerName6, playerName7};
            NumberOfPlayers.Items.Clear();
            for (int i = 2; i < 8; i++)
            {
                NumberOfPlayers.Items.Add(i.ToString());
            }
        }

        
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            try
            {
                int t =((int) NumberOfPlayers.SelectedIndex)+1;
                for (int i = 0; i <7; i++)
                {
                    if (i<=t)
                    {
                        tboxes[i].Visible = true;
                    }
                    else
                    {
                    tboxes[i].Visible = false;
                    }
                
                }
            }
            catch (Exception)
            {

                return;
            }
           
            
            
           
        }

        private void Initial_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_startgame_Click(object sender, EventArgs e)
        {
 List<string> names = new List<string>();
            for (int i = 0; i < tboxes.Length; i++)
            {
                if (tboxes[i].Visible==true)
                {
                    if (tboxes[i].Text=="")
                    {
                        MessageBox.Show("Заполните все поля!!!");
                        return;
                    }
                    names.Add(tboxes[i].Text);
                }
            }
            if (names.Count==0)
            {
                MessageBox.Show("Выберите количество игроков!!!");
                return;
            }
            this.Visible = false;
            MainForm mainForm = new MainForm(names.ToArray());
            mainForm.Visible = true;
            }
                        
           
        
    }
}
