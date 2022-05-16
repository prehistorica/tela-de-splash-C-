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
    public partial class frmPergunta7 : Form
    {
        public frmPergunta7()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            rbA7.Checked = false;
            rbB7.Checked = false;
            rbC7.Checked = false;
            rbD7.Checked = false;
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
                if (rbA7.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta8 p8 = new frmPergunta8();
                    p8.Show();
                    this.Close();
                }
                else if (rbB7.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmPergunta8 p8 = new frmPergunta8();
                    p8.Show();
                    this.Close();
                }
                else if (rbC7.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta8 p8 = new frmPergunta8();
                    p8.Show();
                    this.Close();
                }
                else if (rbD7.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta8 p8 = new frmPergunta8();
                    p8.Show();
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
