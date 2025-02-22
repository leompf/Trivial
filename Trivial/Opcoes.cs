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
using System.Xml;

namespace Trivial
{   
    public partial class Opcoes : Form
    {
        private string nickname = "";
        private int dificuldade = 0;
        private string categoria;

        public Opcoes()
        {
            InitializeComponent();
            this.MaximumSize = new Size(1280, 720);
            this.CenterToScreen();
        }

        private void Opcoes_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\Google Drive\Educação\CINEL_CET95\Projectos_Visual_Studio\Programação de Computadores - Orientada a Objetos\Avaliacao\Jogo\Trivial\Trivial\bin\Debug\Quiz.xml");

            XmlNodeList nodeList = doc.SelectNodes(@"trivia/dificuldade/categoria");

            foreach (XmlNode node in nodeList)
            {
                if (!cbb_categorias.Items.Contains(node.Attributes.GetNamedItem("nome").Value))
                cbb_categorias.Items.Add(node.Attributes.GetNamedItem("nome").Value);
            }
        }

        private void tb_nickname_Enter(object sender, EventArgs e)
        {
            tb_nickname.TextAlign = HorizontalAlignment.Center;
            
        }

        private void tb_nickname_TextChanged(object sender, EventArgs e)
        {
            nickname = tb_nickname.Text;
        }

        private void Dificuldade(object sender, EventArgs e)
        {
            if (rbtn_facil.Checked)
            {
                rtb_descricao.Text = "Acessível para jogadores casuais ou veteranos! Não tem temporizador e contém perguntas simples.";
                dificuldade = 1;
            }
            else if (rbtn_medio.Checked)
            {
                rtb_descricao.Text = "Requer um pouco mais de conhecimento e tem temporizador.";
                dificuldade = 2;
            }
            else if (rbtn_dificil.Checked)
            {
                rtb_descricao.Text = "Um verdadeiro desafio! Vai testar a tua cultura ao mais alto nível. Perguntas avançadas com tempo curto de resposta.";
                dificuldade = 3;
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (cbb_categorias.Text == "" || (!rbtn_facil.Checked) && (!rbtn_medio.Checked) && (!rbtn_dificil.Checked))
            {
                MessageBox.Show("Seleciona uma categoria e dificuldade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                categoria = cbb_categorias.Text;
                Jogo jogo = new Jogo(nickname, dificuldade, categoria);
                
                this.Hide();
                jogo.Show();
            }            
        }      
    }
}
