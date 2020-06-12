namespace VensiGame
{
    partial class Initial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberOfPlayers = new System.Windows.Forms.DomainUpDown();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.playerName3 = new System.Windows.Forms.TextBox();
            this.playerName4 = new System.Windows.Forms.TextBox();
            this.playerName5 = new System.Windows.Forms.TextBox();
            this.playerName6 = new System.Windows.Forms.TextBox();
            this.playerName7 = new System.Windows.Forms.TextBox();
            this.btn_startgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOfPlayers
            // 
            this.NumberOfPlayers.Location = new System.Drawing.Point(42, 30);
            this.NumberOfPlayers.Name = "NumberOfPlayers";
            this.NumberOfPlayers.Size = new System.Drawing.Size(176, 20);
            this.NumberOfPlayers.TabIndex = 0;
            this.NumberOfPlayers.Text = "Выберите количество игроков";
            this.NumberOfPlayers.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // playerName1
            // 
            this.playerName1.AccessibleDescription = "игпгпгп";
            this.playerName1.Location = new System.Drawing.Point(42, 102);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(176, 20);
            this.playerName1.TabIndex = 1;
            this.playerName1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имена игроков";
            // 
            // playerName2
            // 
            this.playerName2.AccessibleDescription = "игпгпгп";
            this.playerName2.Location = new System.Drawing.Point(42, 143);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(176, 20);
            this.playerName2.TabIndex = 3;
            this.playerName2.Visible = false;
            // 
            // playerName3
            // 
            this.playerName3.AccessibleDescription = "игпгпгп";
            this.playerName3.Location = new System.Drawing.Point(42, 183);
            this.playerName3.Name = "playerName3";
            this.playerName3.Size = new System.Drawing.Size(176, 20);
            this.playerName3.TabIndex = 4;
            this.playerName3.Visible = false;
            // 
            // playerName4
            // 
            this.playerName4.AccessibleDescription = "игпгпгп";
            this.playerName4.Location = new System.Drawing.Point(42, 218);
            this.playerName4.Name = "playerName4";
            this.playerName4.Size = new System.Drawing.Size(176, 20);
            this.playerName4.TabIndex = 5;
            this.playerName4.Visible = false;
            this.playerName4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // playerName5
            // 
            this.playerName5.AccessibleDescription = "игпгпгп";
            this.playerName5.Location = new System.Drawing.Point(42, 259);
            this.playerName5.Name = "playerName5";
            this.playerName5.Size = new System.Drawing.Size(176, 20);
            this.playerName5.TabIndex = 6;
            this.playerName5.Visible = false;
            // 
            // playerName6
            // 
            this.playerName6.AccessibleDescription = "игпгпгп";
            this.playerName6.Location = new System.Drawing.Point(42, 297);
            this.playerName6.Name = "playerName6";
            this.playerName6.Size = new System.Drawing.Size(176, 20);
            this.playerName6.TabIndex = 7;
            this.playerName6.Visible = false;
            // 
            // playerName7
            // 
            this.playerName7.AccessibleDescription = "игпгпгп";
            this.playerName7.Location = new System.Drawing.Point(42, 336);
            this.playerName7.Name = "playerName7";
            this.playerName7.Size = new System.Drawing.Size(176, 20);
            this.playerName7.TabIndex = 8;
            this.playerName7.Visible = false;
            // 
            // btn_startgame
            // 
            this.btn_startgame.Location = new System.Drawing.Point(70, 377);
            this.btn_startgame.Name = "btn_startgame";
            this.btn_startgame.Size = new System.Drawing.Size(102, 23);
            this.btn_startgame.TabIndex = 9;
            this.btn_startgame.Text = "Начать игру";
            this.btn_startgame.UseVisualStyleBackColor = true;
            this.btn_startgame.Click += new System.EventHandler(this.btn_startgame_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 412);
            this.Controls.Add(this.btn_startgame);
            this.Controls.Add(this.playerName7);
            this.Controls.Add(this.playerName6);
            this.Controls.Add(this.playerName5);
            this.Controls.Add(this.playerName4);
            this.Controls.Add(this.playerName3);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerName1);
            this.Controls.Add(this.NumberOfPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Initial";
            this.Text = "Initial";
            this.Load += new System.EventHandler(this.Initial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown NumberOfPlayers;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerName2;
        private System.Windows.Forms.TextBox playerName3;
        private System.Windows.Forms.TextBox playerName4;
        private System.Windows.Forms.TextBox playerName5;
        private System.Windows.Forms.TextBox playerName6;
        private System.Windows.Forms.TextBox playerName7;
        private System.Windows.Forms.Button btn_startgame;

    }
}