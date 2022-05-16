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
    public partial class frmPergunta6 : Form
    {
        public frmPergunta6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rbA6.Checked = false;
            rbB6.Checked = false;
            rbC6.Checked = false;
            rbD6.Checked = false;
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
                if (rbA6.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta7 p7 = new frmPergunta7();
                    p7.Show();
                    this.Close();
                }
                else if (rbB6.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmPergunta7 p7 = new frmPergunta7();
                    p7.Show();
                    this.Close();
                }
                else if (rbC6.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta7 p7 = new frmPergunta7();
                    p7.Show();
                    this.Close();
                }
                else if (rbD6.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta7 p7 = new frmPergunta7();
                    p7.Show();
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
