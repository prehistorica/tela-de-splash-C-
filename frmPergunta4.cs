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
    public partial class frmPergunta4 : Form
    {
        public frmPergunta4()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rbA4.Checked = false;
            rbB4.Checked = false;
            rbC4.Checked = false;
            rbD4.Checked = false;

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

        private void btnProxima_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbA4.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos  + 1;
                    frmPergunta5 p5 = new frmPergunta5();
                    p5.Show();
                    this.Close();
                }
                else if (rbB4.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta5 p5 = new frmPergunta5();
                    p5.Show();
                    this.Close();

                }
                else if (rbC4.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta5 p5 = new frmPergunta5();
                    p5.Show();
                    this.Close();
                }
                else if (rbD4.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta5 p5 = new frmPergunta5();
                    p5.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Você Esqueceu de Escolher uma Opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Algo deu Errado");
            }
        }
    }
}
