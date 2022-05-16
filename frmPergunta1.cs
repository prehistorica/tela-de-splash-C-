using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIngadores_Quiz
{
    public partial class frmPergunta1 : Form
    {
        public frmPergunta1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Voltar ao Menu?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                frmMenu voltarmenu = new frmMenu();
                voltarmenu.Show();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rbA1.Checked = false;
            rbB1.Checked = false;
            rbC1.Checked = false;
            rbD1.Checked = false; 
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbA1.Checked == true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta2 p2 = new frmPergunta2();
                    p2.Show();
                    this.Close();
                }
                else if (rbB1.Checked == true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta2 p2 = new frmPergunta2();
                    p2.Show();
                    this.Close();
                }
                else if (rbC1.Checked == true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta2 p2 = new frmPergunta2();
                    p2.Show();
                    this.Close();
                }
                else if (rbD1.Checked == true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmPergunta2 p2 = new frmPergunta2();
                    p2.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Você Esqueceu de Escolher uma Opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message+"Algo deu Errado");
            }
        }
    }
}
