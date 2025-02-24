namespace Trivial
{
    partial class Scoreboard
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
            this.rtb_scores = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_scores
            // 
            this.rtb_scores.BackColor = System.Drawing.Color.Navy;
            this.rtb_scores.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_scores.ForeColor = System.Drawing.Color.Gold;
            this.rtb_scores.Location = new System.Drawing.Point(131, 104);
            this.rtb_scores.Name = "rtb_scores";
            this.rtb_scores.ReadOnly = true;
            this.rtb_scores.Size = new System.Drawing.Size(543, 260);
            this.rtb_scores.TabIndex = 0;
            this.rtb_scores.Text = "";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_scores);
            this.Name = "Scoreboard";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scoreboard_FormClosed);
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_scores;
    }
}