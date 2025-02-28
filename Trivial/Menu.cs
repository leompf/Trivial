using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Trivial
{
    public partial class Menu : Form
    {
        // Lógica
        Opcoes opcoes = new Opcoes();
        public static SoundPlayer musica = new SoundPlayer();
        public static SoundPlayer somBotao = new SoundPlayer();
        public static Menu instancia;

        public void Resolucao()
        {
            this.MaximumSize = new Size(1280, 720);
            this.CenterToScreen();
        }

        public Menu()
        {
            InitializeComponent();
            Resolucao();
            instancia = this;

            AnimacaoTitulo();
            CorTitulo();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            somBotao.Play();
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
            somBotao.Play();
            this.Hide();

            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            somBotao.Play();
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            somBotao.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clicar botao.wav");
            musica.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"What If So Then - Karneef.wav");
            musica.PlayLooping();
        }

        private void cbx_mute_Click(object sender, EventArgs e)
        {
            if (cbx_mute.Checked == true)
            {
                musica.Stop();
            }
            else
            {
                musica.Play();
            }
        }
    }
}
