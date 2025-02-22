namespace Trivial
{
    partial class Menu
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.btn_scores = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(358, 100);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(537, 86);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Trivia Challenge!";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_jogar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jogar.ForeColor = System.Drawing.Color.Gold;
            this.btn_jogar.Location = new System.Drawing.Point(251, 361);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(200, 50);
            this.btn_jogar.TabIndex = 1;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            this.btn_jogar.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_jogar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_scores
            // 
            this.btn_scores.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_scores.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scores.ForeColor = System.Drawing.Color.Gold;
            this.btn_scores.Location = new System.Drawing.Point(536, 361);
            this.btn_scores.Name = "btn_scores";
            this.btn_scores.Size = new System.Drawing.Size(200, 50);
            this.btn_scores.TabIndex = 2;
            this.btn_scores.Text = "Scores";
            this.btn_scores.UseVisualStyleBackColor = false;
            this.btn_scores.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_scores.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_sair.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Gold;
            this.btn_sair.Location = new System.Drawing.Point(837, 361);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(200, 50);
            this.btn_sair.TabIndex = 3;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_sair.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_scores);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Button btn_scores;
        private System.Windows.Forms.Button btn_sair;
    }
}

