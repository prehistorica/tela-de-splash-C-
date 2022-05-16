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
    public partial class frmPergunta2 : Form
    {
        public frmPergunta2()
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
            rbA2.Checked = false;
            rbB2.Checked = false;
            rbC2.Checked = false;
            rbD2.Checked = false; 
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbA2.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta3 p3 = new frmPergunta3();
                    p3.Show();
                    this.Close();
                }
                else if (rbB2.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta3 p3 = new frmPergunta3();
                    p3.Show();
                    this.Close();
                }
                else if (rbC2.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta3 p3 = new frmPergunta3();
                    p3.Show();
                    this.Close();
                }
                else if (rbD2.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmPergunta3 p3 = new frmPergunta3();
                    p3.Show();
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
