using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Trivial
{
    public partial class Jogo : Form
    {
        // Lógica
        XmlDocument doc;

        private string nickname;
        private int dificuldade;
        private string categoria;
        private int perguntaAtual;
        private int score;
        private Random random = new Random();
        TimeSpan tempoRestante = new TimeSpan();

        public Jogo(string nickname, int dificuldade, string categoria)
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            this.CenterToScreen();

            this.nickname = nickname;
            this.dificuldade = dificuldade;
            this.categoria = categoria;
        }

        private void Jogo_Load(object sender, EventArgs e)
        {
            lbl_nickname.Text = nickname;

            if (dificuldade == 2)
            {
                tempoRestante = TimeSpan.FromSeconds(30);
                lbl_timer.Text = tempoRestante.ToString(@"ss");
            }
            else if (dificuldade == 3)
            {
                tempoRestante = TimeSpan.FromSeconds(15);
                lbl_timer.Text = tempoRestante.ToString(@"ss");
            }

            timer1.Start();

            ExibirPerguntaAtual();
        }

        private class Pergunta
        {
            public string Texto { get; set; }
            public List<string> Opcoes { get; set; }
            public string RespostaCorreta { get; set; }
        }

        private List<Pergunta> listaPerguntas;
 
        private void Perguntas()
        {
            doc = new XmlDocument();
            doc.Load(@"E:\Google Drive\Educação\CINEL_CET95\Projectos_Visual_Studio\Programação de Computadores - Orientada a Objetos\Avaliacao\Jogo\Trivial\Trivial\bin\Debug\Quiz.xml");

            listaPerguntas = new List<Pergunta>();

            string dificuldadeSelecionada = dificuldade == 1 ? "Fácil" : dificuldade == 2 ? "Médio" : "Difícil";

            XmlNodeList nodePerguntas = doc.SelectNodes($"/trivia/dificuldade[@nivel='{dificuldadeSelecionada}']/categoria[@nome='{categoria}']/pergunta");


            foreach (XmlNode pergunta in nodePerguntas)
            {
                string textoPergunta = pergunta["texto"].InnerText;
                List<string> respostas = new List<string>();
                string respostaCorreta = "";

                foreach (XmlNode resposta in pergunta.SelectNodes("resposta"))
                {
                    respostas.Add(resposta.InnerText);

                    if (resposta.Attributes["correta"] != null && resposta.Attributes["correta"].Value == "sim")
                    {
                        respostaCorreta = resposta.InnerText;
                    }
                }

                listaPerguntas.Add(new Pergunta
                {
                    Texto = textoPergunta,
                    Opcoes = respostas,
                    RespostaCorreta = respostaCorreta
                });
            }             
        }

        private void ExibirPerguntaAtual()
        {
            Perguntas();

            if (dificuldade == 2)
            {
                tempoRestante = TimeSpan.FromSeconds(30);
            }
            else if (dificuldade == 3)
            {
                tempoRestante = TimeSpan.FromSeconds(15);
            }

            if (perguntaAtual >= listaPerguntas.Count)
            {
                MessageBox.Show("Fim do jogo!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Stop();
                CarregarScore();
                this.Close();

                Menu menu = new Menu();
                menu.Show();
                return;
            }

            Pergunta pergunta = listaPerguntas[perguntaAtual];
            lbl_pergunta.Text = pergunta.Texto;

            List<string> respostasAleatorias = pergunta.Opcoes.OrderBy(x => random.Next()).ToList();

            btn_resposta1.Text = respostasAleatorias[0];
            btn_resposta2.Text = respostasAleatorias[1];
            btn_resposta3.Text = respostasAleatorias[2];
            btn_resposta4.Text = respostasAleatorias[3];
        }

        private void CicloPerguntas(object sender, EventArgs e)
        {
            Button botaoClicado = sender as Button;
            Pergunta pergunta = listaPerguntas[perguntaAtual];

            if (botaoClicado.Text == pergunta.RespostaCorreta)
            {
                score += 10;
                lbl_score.Text = score.ToString();
            }

            perguntaAtual++;
            ExibirPerguntaAtual();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempoRestante.TotalSeconds > 0)
            {
                tempoRestante = tempoRestante.Subtract(TimeSpan.FromSeconds(1));
                lbl_timer.Text = tempoRestante.ToString(@"ss");
            }
            else
            {
                timer1.Stop();
                perguntaAtual++;
                ExibirPerguntaAtual();
                timer1.Start();
            }
        }

        private void CarregarScore()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scores.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(caminho, true))
                {
                    writer.WriteLine($"{nickname} - {score}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar pontuacao", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            btn.ForeColor = Color.White;
        }      
    }
}
