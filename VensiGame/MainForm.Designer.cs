namespace VensiGame
{
    partial class MainForm
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
            this.btn_move = new System.Windows.Forms.Button();
            this.player_pannel = new System.Windows.Forms.Panel();
            this.player2_pannel = new System.Windows.Forms.Panel();
            this.Deck_pannel = new System.Windows.Forms.Panel();
            this.pb_curcard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.player_pannel.SuspendLayout();
            this.player2_pannel.SuspendLayout();
            this.Deck_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_curcard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(325, 185);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(119, 23);
            this.btn_move.TabIndex = 0;
            this.btn_move.Text = "Сделать ход";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Visible = false;
            // 
            // player_pannel
            // 
            this.player_pannel.Controls.Add(this.button1);
            this.player_pannel.Location = new System.Drawing.Point(13, 239);
            this.player_pannel.Name = "player_pannel";
            this.player_pannel.Size = new System.Drawing.Size(664, 199);
            this.player_pannel.TabIndex = 2;
            // 
            // player2_pannel
            // 
            this.player2_pannel.Controls.Add(this.button1);
            this.player2_pannel.Location = new System.Drawing.Point(13, 439);
            this.player2_pannel.Name = "player2_pannel";
            this.player2_pannel.Size = new System.Drawing.Size(664, 199);
            // 
            // playerDeck_pannel
            // 
            this.Deck_pannel.Controls.Add(this.button1);
            this.Deck_pannel.Location = new System.Drawing.Point(300, 300);
            this.Deck_pannel.Name = "player_pannel";
            this.Deck_pannel.Size = new System.Drawing.Size(664, 199);
            // 
            // pb_curcard
            // 
            this.pb_curcard.Location = new System.Drawing.Point(325, 12);
            this.pb_curcard.Name = "pb_curcard";
            this.pb_curcard.Size = new System.Drawing.Size(119, 167);
            this.pb_curcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_curcard.TabIndex = 3;
            this.pb_curcard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество очков:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(720, 308);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(13, 13);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "0";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(325, 210);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(119, 23);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Забрать колоду";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(740, 12);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(13, 13);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_curcard);
            this.Controls.Add(this.player_pannel);
            this.Controls.Add(this.player2_pannel);
            this.Controls.Add(this.btn_move);
            this.Name = "Deck";
            this.Text = "MainForm";
            this.player_pannel.ResumeLayout(false);
            this.player2_pannel.ResumeLayout(false);
            this.Deck_pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_curcard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Panel player_pannel;
        private System.Windows.Forms.Panel player2_pannel;
        private System.Windows.Forms.Panel Deck_pannel;
        private System.Windows.Forms.PictureBox pb_curcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button button1;
    }
}