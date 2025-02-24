using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivial
{
    public partial class Menu : Form
    {
        // Lógica
        Opcoes opcoes = new Opcoes();

        public void Resolucao()
        {
            this.MaximumSize = new Size(1280, 720);
            this.CenterToScreen();
        }

        public Menu()
        {
            InitializeComponent();
            Resolucao();

            AnimacaoTitulo();
            CorTitulo();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            opcoes.Show();
        }

        // Customizações de UI
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Gold;
            btn.ForeColor = Color.Black;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkBlue;
            btn.ForeColor = Color.Gold;
        }

        private Timer timer;
        private int posicaoAlvo = 320;
        private int velocidade = 40;

        private void AnimacaoTitulo()
        {
            lbl_titulo.Left = -lbl_titulo.Width; // Start outside the screen
            timer = new Timer();
            timer.Interval = 20; // Adjust speed
            timer.Tick += MoverTitulo;
            timer.Start();
        }
        private void MoverTitulo(object sender, EventArgs e)
        {
            if (lbl_titulo.Left < posicaoAlvo)
            {
                lbl_titulo.Left += velocidade; // Move right
            }
            else
            {
                timer.Stop();
            }
        }

        private Timer timerCor;
        private bool cor1 = true;

        private void CorTitulo()
        {
            timerCor = new Timer();
            timerCor.Interval = 350;
            timerCor.Tick += AlternarCorTitulo;
            timerCor.Start();
        }

        private void AlternarCorTitulo(object sender, EventArgs e)
        {
            if (cor1)
                lbl_titulo.ForeColor = Color.White;
            else
                lbl_titulo.ForeColor = Color.Gold;

            cor1 = !cor1; 
        }

        private void btn_scores_Click(object sender, EventArgs e)
        {
            this.Hide();

            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Show();
        }
    }
}
