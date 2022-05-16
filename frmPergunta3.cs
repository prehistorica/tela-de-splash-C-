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
    public partial class frmPergunta3 : Form
    {
        public frmPergunta3()
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
            rbA3.Checked = false;
            rbB3.Checked = false;
            rbC3.Checked = false;
            rbD3.Checked = false;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbA3.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmPergunta4 p4 = new frmPergunta4();
                    p4.Show();
                    this.Close();
                }
                else if (rbB3.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmPergunta4 p4 = new frmPergunta4();
                    p4.Show();
                    this.Close();
                }
                else if (rbC3.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmPergunta4 p4 = new frmPergunta4();
                    p4.Show();
                    this.Close();
                }
                else if (rbD3.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmPergunta4 p4 = new frmPergunta4();
                    p4.Show();
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

