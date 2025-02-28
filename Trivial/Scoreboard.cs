using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivial
{
    public partial class Scoreboard: Form
    {
        public static Scoreboard instancia;

        public Scoreboard()
        {
            InitializeComponent();
            this.MaximumSize = new Size(816, 489);
            instancia = this;
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scores.txt");

            using (StreamReader sr = new StreamReader(caminho))
            {
                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    rtb_scores.AppendText($"{linha}\n");
                }
            }
        }

        private void Scoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trivial.Menu.instancia.Show();
        }
    }
}
