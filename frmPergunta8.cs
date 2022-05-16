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
    public partial class frmPergunta8 : Form
    {
        public frmPergunta8()
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
            rbA8.Checked = false;
            rbB8.Checked = false;
            rbC8.Checked = false;
            rbD8.Checked = false;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {

            try
            {
                if (rbA8.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 2;
                    frmResultado resultado = new frmResultado();
                    resultado.Show();
                    this.Close();
                }
                else if (rbB8.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 1;
                    frmResultado resultado = new frmResultado();
                    resultado.Show();
                    this.Close();
                }
                else if (rbC8.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 3;
                    frmResultado resultado = new frmResultado();
                    resultado.Show();
                    this.Close();
                }
                else if (rbD8.Checked==true)
                {
                    pontuacao.pontos = pontuacao.pontos + 4;
                    frmResultado resultado = new frmResultado();
                    resultado.Show();
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
