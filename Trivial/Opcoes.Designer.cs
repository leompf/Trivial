namespace Trivial
{
    partial class Opcoes
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
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.tb_nickname = new System.Windows.Forms.TextBox();
            this.lbl_categorias = new System.Windows.Forms.Label();
            this.cbb_categorias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_facil = new System.Windows.Forms.RadioButton();
            this.rbtn_medio = new System.Windows.Forms.RadioButton();
            this.rbtn_dificil = new System.Windows.Forms.RadioButton();
            this.rtb_descricao = new System.Windows.Forms.RichTextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.AutoSize = true;
            this.lbl_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nickname.Location = new System.Drawing.Point(54, 51);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(178, 39);
            this.lbl_nickname.TabIndex = 0;
            this.lbl_nickname.Text = "Nickname:";
            // 
            // tb_nickname
            // 
            this.tb_nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nickname.Location = new System.Drawing.Point(238, 52);
            this.tb_nickname.Name = "tb_nickname";
            this.tb_nickname.Size = new System.Drawing.Size(227, 38);
            this.tb_nickname.TabIndex = 1;
            this.tb_nickname.TextChanged += new System.EventHandler(this.tb_nickname_TextChanged);
            this.tb_nickname.Enter += new System.EventHandler(this.tb_nickname_Enter);
            // 
            // lbl_categorias
            // 
            this.lbl_categorias.AutoSize = true;
            this.lbl_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categorias.Location = new System.Drawing.Point(577, 52);
            this.lbl_categorias.Name = "lbl_categorias";
            this.lbl_categorias.Size = new System.Drawing.Size(191, 39);
            this.lbl_categorias.TabIndex = 2;
            this.lbl_categorias.Text = "Categorias:";
            // 
            // cbb_categorias
            // 
            this.cbb_categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_categorias.FormattingEnabled = true;
            this.cbb_categorias.Location = new System.Drawing.Point(774, 51);
            this.cbb_categorias.Name = "cbb_categorias";
            this.cbb_categorias.Size = new System.Drawing.Size(153, 37);
            this.cbb_categorias.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "- Dificuldade +";
            // 
            // rbtn_facil
            // 
            this.rbtn_facil.AutoSize = true;
            this.rbtn_facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_facil.Location = new System.Drawing.Point(382, 295);
            this.rbtn_facil.Name = "rbtn_facil";
            this.rbtn_facil.Size = new System.Drawing.Size(83, 33);
            this.rbtn_facil.TabIndex = 5;
            this.rbtn_facil.TabStop = true;
            this.rbtn_facil.Text = "Fácil";
            this.rbtn_facil.UseVisualStyleBackColor = true;
            this.rbtn_facil.CheckedChanged += new System.EventHandler(this.Dificuldade);
            // 
            // rbtn_medio
            // 
            this.rbtn_medio.AutoSize = true;
            this.rbtn_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_medio.Location = new System.Drawing.Point(550, 295);
            this.rbtn_medio.Name = "rbtn_medio";
            this.rbtn_medio.Size = new System.Drawing.Size(99, 33);
            this.rbtn_medio.TabIndex = 6;
            this.rbtn_medio.TabStop = true;
            this.rbtn_medio.Text = "Médio";
            this.rbtn_medio.UseVisualStyleBackColor = true;
            this.rbtn_medio.CheckedChanged += new System.EventHandler(this.Dificuldade);
            // 
            // rbtn_dificil
            // 
            this.rbtn_dificil.AutoSize = true;
            this.rbtn_dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_dificil.Location = new System.Drawing.Point(736, 295);
            this.rbtn_dificil.Name = "rbtn_dificil";
            this.rbtn_dificil.Size = new System.Drawing.Size(90, 33);
            this.rbtn_dificil.TabIndex = 7;
            this.rbtn_dificil.TabStop = true;
            this.rbtn_dificil.Text = "Difícil";
            this.rbtn_dificil.UseVisualStyleBackColor = true;
            this.rbtn_dificil.CheckedChanged += new System.EventHandler(this.Dificuldade);
            // 
            // rtb_descricao
            // 
            this.rtb_descricao.Location = new System.Drawing.Point(459, 352);
            this.rtb_descricao.Name = "rtb_descricao";
            this.rtb_descricao.Size = new System.Drawing.Size(309, 60);
            this.rtb_descricao.TabIndex = 8;
            this.rtb_descricao.Text = "";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(512, 446);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(199, 61);
            this.btn_iniciar.TabIndex = 9;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // Opcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.rtb_descricao);
            this.Controls.Add(this.rbtn_dificil);
            this.Controls.Add(this.rbtn_medio);
            this.Controls.Add(this.rbtn_facil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_categorias);
            this.Controls.Add(this.lbl_categorias);
            this.Controls.Add(this.tb_nickname);
            this.Controls.Add(this.lbl_nickname);
            this.Name = "Opcoes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Opcoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nickname;
        private System.Windows.Forms.TextBox tb_nickname;
        private System.Windows.Forms.Label lbl_categorias;
        private System.Windows.Forms.ComboBox cbb_categorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_facil;
        private System.Windows.Forms.RadioButton rbtn_medio;
        private System.Windows.Forms.RadioButton rbtn_dificil;
        private System.Windows.Forms.RichTextBox rtb_descricao;
        private System.Windows.Forms.Button btn_iniciar;
    }
}