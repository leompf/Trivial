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

    }
}
