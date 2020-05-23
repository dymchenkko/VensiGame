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
            this.button1 = new System.Windows.Forms.Button();
            this.player2_pannel = new System.Windows.Forms.Panel();
            this.Deck_pannel = new System.Windows.Forms.Panel();
            this.pb_curcard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.Deck_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_curcard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(433, 228);
            this.btn_move.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(159, 28);
            this.btn_move.TabIndex = 0;
            this.btn_move.Text = "Сделать ход";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Visible = false;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // player_pannel
            // 
            this.player_pannel.Location = new System.Drawing.Point(17, 294);
            this.player_pannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_pannel.Name = "player_pannel";
            this.player_pannel.Size = new System.Drawing.Size(885, 245);
            this.player_pannel.TabIndex = 2;
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
            // player2_pannel
            // 
            this.player2_pannel.Location = new System.Drawing.Point(17, 540);
            this.player2_pannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2_pannel.Name = "player2_pannel";
            this.player2_pannel.Size = new System.Drawing.Size(885, 245);
            this.player2_pannel.TabIndex = 8;
            // 
            // Deck_pannel
            // 
            this.Deck_pannel.Controls.Add(this.button1);
            this.Deck_pannel.Location = new System.Drawing.Point(300, 300);
            this.Deck_pannel.Name = "Deck_pannel";
            this.Deck_pannel.Size = new System.Drawing.Size(664, 199);
            this.Deck_pannel.TabIndex = 0;
            // 
            // pb_curcard
            // 
            this.pb_curcard.Location = new System.Drawing.Point(433, 15);
            this.pb_curcard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_curcard.Name = "pb_curcard";
            this.pb_curcard.Size = new System.Drawing.Size(159, 206);
            this.pb_curcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_curcard.TabIndex = 3;
            this.pb_curcard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество очков:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(960, 379);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(16, 17);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "0";
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(433, 258);
            this.btn_get.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(159, 28);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Забрать колоду";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Visible = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(987, 15);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(16, 17);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 663);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_curcard);
            this.Controls.Add(this.player_pannel);
            this.Controls.Add(this.player2_pannel);
            this.Controls.Add(this.btn_move);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
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