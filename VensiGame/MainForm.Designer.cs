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
            this.button1 = new System.Windows.Forms.Button();
            this.Deck_pannel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_Active = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_score2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cur_score = new System.Windows.Forms.Label();
            this.Deck_pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_move
            // 
            this.btn_move.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_move.Location = new System.Drawing.Point(723, 69);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(119, 23);
            this.btn_move.TabIndex = 0;
            this.btn_move.Text = "Сделать ход";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
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
            // Deck_pannel
            // 
            this.Deck_pannel.Controls.Add(this.button1);
            this.Deck_pannel.Location = new System.Drawing.Point(300, 300);
            this.Deck_pannel.Name = "Deck_pannel";
            this.Deck_pannel.Size = new System.Drawing.Size(664, 199);
            this.Deck_pannel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(673, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вам необходимо набрать:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(686, 186);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(0, 13);
            this.lbl_score.TabIndex = 5;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(723, 98);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(119, 23);
            this.btn_get.TabIndex = 6;
            this.btn_get.Text = "Забрать колоду";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_Active
            // 
            this.lbl_Active.AutoSize = true;
            this.lbl_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Active.ForeColor = System.Drawing.Color.Red;
            this.lbl_Active.Location = new System.Drawing.Point(12, 9);
            this.lbl_Active.Name = "lbl_Active";
            this.lbl_Active.Size = new System.Drawing.Size(0, 25);
            this.lbl_Active.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(332, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 167);
            this.panel1.TabIndex = 12;
            // 
            // lbl_score2
            // 
            this.lbl_score2.AutoSize = true;
            this.lbl_score2.Location = new System.Drawing.Point(686, 210);
            this.lbl_score2.Name = "lbl_score2";
            this.lbl_score2.Size = new System.Drawing.Size(0, 13);
            this.lbl_score2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(673, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "У вас очков:";
            // 
            // cur_score
            // 
            this.cur_score.AutoSize = true;
            this.cur_score.ForeColor = System.Drawing.Color.Red;
            this.cur_score.Location = new System.Drawing.Point(774, 237);
            this.cur_score.Name = "cur_score";
            this.cur_score.Size = new System.Drawing.Size(0, 13);
            this.cur_score.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 609);
            this.Controls.Add(this.cur_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_score2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Active);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Deck_pannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Panel Deck_pannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_Active;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_score2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cur_score;
    }
    }