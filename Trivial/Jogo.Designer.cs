namespace Trivial
{
    partial class Jogo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.btn_resposta1 = new System.Windows.Forms.Button();
            this.btn_resposta2 = new System.Windows.Forms.Button();
            this.btn_resposta3 = new System.Windows.Forms.Button();
            this.btn_resposta4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador:";
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.AutoSize = true;
            this.lbl_nickname.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nickname.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nickname.Location = new System.Drawing.Point(148, 30);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(83, 32);
            this.lbl_nickname.TabIndex = 1;
            this.lbl_nickname.Text = "Nome";
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pergunta.ForeColor = System.Drawing.Color.White;
            this.lbl_pergunta.Location = new System.Drawing.Point(12, 104);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(1231, 107);
            this.lbl_pergunta.TabIndex = 2;
            this.lbl_pergunta.Text = "Pergunta";
            this.lbl_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_resposta1
            // 
            this.btn_resposta1.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_resposta1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resposta1.ForeColor = System.Drawing.Color.White;
            this.btn_resposta1.Location = new System.Drawing.Point(187, 245);
            this.btn_resposta1.Name = "btn_resposta1";
            this.btn_resposta1.Size = new System.Drawing.Size(351, 122);
            this.btn_resposta1.TabIndex = 3;
            this.btn_resposta1.Text = "Resposta";
            this.btn_resposta1.UseVisualStyleBackColor = false;
            this.btn_resposta1.Click += new System.EventHandler(this.CicloPerguntas);
            this.btn_resposta1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_resposta1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_resposta2
            // 
            this.btn_resposta2.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_resposta2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resposta2.ForeColor = System.Drawing.Color.White;
            this.btn_resposta2.Location = new System.Drawing.Point(712, 245);
            this.btn_resposta2.Name = "btn_resposta2";
            this.btn_resposta2.Size = new System.Drawing.Size(351, 122);
            this.btn_resposta2.TabIndex = 4;
            this.btn_resposta2.Text = "Resposta";
            this.btn_resposta2.UseVisualStyleBackColor = false;
            this.btn_resposta2.Click += new System.EventHandler(this.CicloPerguntas);
            this.btn_resposta2.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_resposta2.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_resposta3
            // 
            this.btn_resposta3.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_resposta3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resposta3.ForeColor = System.Drawing.Color.White;
            this.btn_resposta3.Location = new System.Drawing.Point(187, 462);
            this.btn_resposta3.Name = "btn_resposta3";
            this.btn_resposta3.Size = new System.Drawing.Size(351, 122);
            this.btn_resposta3.TabIndex = 5;
            this.btn_resposta3.Text = "Resposta";
            this.btn_resposta3.UseVisualStyleBackColor = false;
            this.btn_resposta3.Click += new System.EventHandler(this.CicloPerguntas);
            this.btn_resposta3.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_resposta3.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_resposta4
            // 
            this.btn_resposta4.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_resposta4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resposta4.ForeColor = System.Drawing.Color.White;
            this.btn_resposta4.Location = new System.Drawing.Point(712, 462);
            this.btn_resposta4.Name = "btn_resposta4";
            this.btn_resposta4.Size = new System.Drawing.Size(351, 122);
            this.btn_resposta4.TabIndex = 6;
            this.btn_resposta4.Text = "Resposta";
            this.btn_resposta4.UseVisualStyleBackColor = false;
            this.btn_resposta4.Click += new System.EventHandler(this.CicloPerguntas);
            this.btn_resposta4.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_resposta4.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(962, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score:";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Gold;
            this.lbl_score.Location = new System.Drawing.Point(1040, 30);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(33, 37);
            this.lbl_score.TabIndex = 8;
            this.lbl_score.Text = "0";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.Color.Red;
            this.lbl_timer.Location = new System.Drawing.Point(586, 33);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(40, 46);
            this.lbl_timer.TabIndex = 9;
            this.lbl_timer.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_resposta4);
            this.Controls.Add(this.btn_resposta3);
            this.Controls.Add(this.btn_resposta2);
            this.Controls.Add(this.btn_resposta1);
            this.Controls.Add(this.lbl_pergunta);
            this.Controls.Add(this.lbl_nickname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Jogo";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Jogo_FormClosed);
            this.Load += new System.EventHandler(this.Jogo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nickname;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Button btn_resposta1;
        private System.Windows.Forms.Button btn_resposta2;
        private System.Windows.Forms.Button btn_resposta3;
        private System.Windows.Forms.Button btn_resposta4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
    }
}