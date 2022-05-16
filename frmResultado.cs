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
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }

        private void frmResultado_Load(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            lblFrase.Visible = false; 
            pbHomemAranha.Visible = false;
            pbDoutorEstranho.Visible = false;
            pbFeiticeiraEscarlate.Visible = false;
            pbThor.Visible = false;
            pbHulk.Visible = false;
            pbViuvaNegra.Visible = false;
            pbHomemdeFerro.Visible = false;
            pbCapitaoAmerica.Visible = false;
            lblFinal.Visible = false; 
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (pontuacao.pontos== 8 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem Aranha";
                    pbHomemAranha.Visible = true;
                    lblFrase.Visible = true;


                }
                else if (pontuacao.pontos== 9 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem Aranha";
                    pbHomemAranha.Visible = true;
                    lblFrase.Visible = true;

                }
                else if (pontuacao.pontos== 10)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem Aranha";
                    pbHomemAranha.Visible = true;
                    lblFrase.Visible = true;

                }
                else if (pontuacao.pontos == 11 )
                {
                    pbDoutorEstranho.Visible = true;
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Doutor Estranho";
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Doutor Estranho tem uma personalidade totalmente complexa, pois apesar de antigamente ele ser completamente arrogante, egoísta, materialista e convencido, características consideradas terríveis num ser-humano, nos conseguimos simpatizar com ele.";
                }
                else if (pontuacao.pontos== 12)
                {
                    pbDoutorEstranho.Visible = true;
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Doutor Estranho";
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Doutor Estranho tem uma personalidade totalmente complexa, pois apesar de antigamente ele ser completamente arrogante, egoísta, materialista e convencido, características consideradas terríveis num ser-humano, nos conseguimos simpatizar com ele.";

                }
                else if (pontuacao.pontos== 13)
                {
                    pbDoutorEstranho.Visible = true;
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Doutor Estranho";
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Doutor Estranho tem uma personalidade totalmente complexa, pois apesar de antigamente ele ser completamente arrogante, egoísta, materialista e convencido, características consideradas terríveis num ser-humano, nos conseguimos simpatizar com ele.";
                }
                else if (pontuacao.pontos == 14 )
                {
                    lblResultado.Visible = true;
                    lblFinal.Visible = true;
                    pbFeiticeiraEscarlate.Visible = true; 
                    lblResultado.Text = "Você é a Feiticeira Escarlate";
                    lblFinal.Text = "Reservada, porém guarda dentro de si sentimentos intensos que vez ou outra são demonstrados de forma descontrolada. – As vezes sente-se uma renegada nos Vingadores.";

                }
                else if (pontuacao.pontos== 15)
                {
                    lblResultado.Visible = true;
                    lblFinal.Visible = true;
                    pbFeiticeiraEscarlate.Visible = true;
                    lblResultado.Text = "Você é a Feiticeira Escarlate";
                    lblFinal.Text = "Reservada, porém guarda dentro de si sentimentos intensos que vez ou outra são demonstrados de forma descontrolada. – As vezes sente-se uma renegada nos Vingadores.";
                }
                else if (pontuacao.pontos== 16)
                {
                    lblResultado.Visible = true;
                    lblFinal.Visible = true;
                    pbFeiticeiraEscarlate.Visible = true;
                    lblResultado.Text = "Você é a Feiticeira Escarlate";
                    lblFinal.Text = "Reservada, porém guarda dentro de si sentimentos intensos que vez ou outra são demonstrados de forma descontrolada. – As vezes sente-se uma renegada nos Vingadores.";
                }
                else if (pontuacao.pontos == 17 ) 
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Thor";
                    pbThor.Visible = true; 
                    lblFinal.Visible = true; 
                    lblFinal.Text = "Thor já foi prepotente e arrogante, o que fez com que seu pai, Odin, o banisse para a Terra para que ele aprendesse um pouco sobre humildade. Depois de aprender algumas lições, ele desenvolveu um forte senso de honra e heroísmo, além da já existente voraz sede pela guerra.";
                }
                else if (pontuacao.pontos== 18)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Thor";
                    pbThor.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "Thor já foi prepotente e arrogante, o que fez com que seu pai, Odin, o banisse para a Terra para que ele aprendesse um pouco sobre humildade. Depois de aprender algumas lições, ele desenvolveu um forte senso de honra e heroísmo, além da já existente voraz sede pela guerra.";
                }
                else if (pontuacao.pontos== 19)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Thor";
                    pbThor.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "Thor já foi prepotente e arrogante, o que fez com que seu pai, Odin, o banisse para a Terra para que ele aprendesse um pouco sobre humildade. Depois de aprender algumas lições, ele desenvolveu um forte senso de honra e heroísmo, além da já existente voraz sede pela guerra.";
                }
                else if (pontuacao.pontos == 20 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Hulk";
                    pbHulk.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Hulk possui grande resistência física, tornando-o próximo a invulnerabilidade. A pele dele suporta balas, explosões e altíssimas e baixíssimas temperaturas. Ele pode sobreviver no espaço e já sobreviveu a uma reentrada na atmosfera terrestre. O Hulk é imune a todas as doenças terrestres conhecidas, inclusive AIDS.";
                }
                else if (pontuacao.pontos== 21)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Hulk";
                    pbHulk.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Hulk possui grande resistência física, tornando-o próximo a invulnerabilidade. A pele dele suporta balas, explosões e altíssimas e baixíssimas temperaturas. Ele pode sobreviver no espaço e já sobreviveu a uma reentrada na atmosfera terrestre. O Hulk é imune a todas as doenças terrestres conhecidas, inclusive AIDS.";
                }
                else if (pontuacao.pontos==22)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Hulk";
                    pbHulk.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Hulk possui grande resistência física, tornando-o próximo a invulnerabilidade. A pele dele suporta balas, explosões e altíssimas e baixíssimas temperaturas. Ele pode sobreviver no espaço e já sobreviveu a uma reentrada na atmosfera terrestre. O Hulk é imune a todas as doenças terrestres conhecidas, inclusive AIDS.";
                }
                else if (pontuacao.pontos== 23 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é a Viúva Negra";
                    pbViuvaNegra.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "Agilidade e Combate. Apesar das características físicas avançadas, as melhores qualidades da Viúva Negra se dá em sua agilidade e capacidades marciais. Somente agentes sobre-humanos podem vencê-la em combate direto, e as vezes nem isso.";

                }
                else if (pontuacao.pontos== 24)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é a Viúva Negra";
                    pbViuvaNegra.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "Agilidade e Combate. Apesar das características físicas avançadas, as melhores qualidades da Viúva Negra se dá em sua agilidade e capacidades marciais. Somente agentes sobre-humanos podem vencê-la em combate direto, e as vezes nem isso.";
                }
                else if (pontuacao.pontos== 25)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é a Viúva Negra";
                    pbViuvaNegra.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "Agilidade e Combate. Apesar das características físicas avançadas, as melhores qualidades da Viúva Negra se dá em sua agilidade e capacidades marciais. Somente agentes sobre-humanos podem vencê-la em combate direto, e as vezes nem isso.";
                }
                else if (pontuacao.pontos == 26 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem de Ferro";
                    pbHomemdeFerro.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Homem de Ferro possui uma personalidade muito forte, principalmente quando surgiu, não se importando em ser inconveniente, chato e, na maioria das vezes, arrogante – seja como super-herói ou como Tony Stark -, e esse é um dos pontos que fazem o personagem ser tão especial, pois foge de muitos clichês dos heróis quase ...";


                }
                else if (pontuacao.pontos== 27)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem de Ferro";
                    pbHomemdeFerro.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Homem de Ferro possui uma personalidade muito forte, principalmente quando surgiu, não se importando em ser inconveniente, chato e, na maioria das vezes, arrogante – seja como super-herói ou como Tony Stark -, e esse é um dos pontos que fazem o personagem ser tão especial, pois foge de muitos clichês dos heróis quase ...";
                }
                else if (pontuacao.pontos == 28)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Homem de Ferro";
                    pbHomemdeFerro.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = "O Homem de Ferro possui uma personalidade muito forte, principalmente quando surgiu, não se importando em ser inconveniente, chato e, na maioria das vezes, arrogante – seja como super-herói ou como Tony Stark -, e esse é um dos pontos que fazem o personagem ser tão especial, pois foge de muitos clichês dos heróis quase ...";
                }
                else if (pontuacao.pontos == 29 )
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Capítão América";
                    pbCapitaoAmerica.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = " Habilidades Mentais: Seu intelecto foi modificado a ponto poder processar muitas informações muito mais rápido, tornando-o um verdadeiro gênio tático. Alem disso, sua memória também permite lembrar de situações já vividas com maior facilidade, melhorando suas tomadas de decisão.";
                }
                else if (pontuacao.pontos== 30)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Capítão América";
                    pbCapitaoAmerica.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = " Habilidades Mentais: Seu intelecto foi modificado a ponto poder processar muitas informações muito mais rápido, tornando-o um verdadeiro gênio tático. Alem disso, sua memória também permite lembrar de situações já vividas com maior facilidade, melhorando suas tomadas de decisão.";
                }
                else if (pontuacao.pontos== 31)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Capítão América";
                    pbCapitaoAmerica.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = " Habilidades Mentais: Seu intelecto foi modificado a ponto poder processar muitas informações muito mais rápido, tornando-o um verdadeiro gênio tático. Alem disso, sua memória também permite lembrar de situações já vividas com maior facilidade, melhorando suas tomadas de decisão.";
                }
                else if (pontuacao.pontos==32)
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você é o Capítão América";
                    pbCapitaoAmerica.Visible = true;
                    lblFinal.Visible = true;
                    lblFinal.Text = " Habilidades Mentais: Seu intelecto foi modificado a ponto poder processar muitas informações muito mais rápido, tornando-o um verdadeiro gênio tático. Alem disso, sua memória também permite lembrar de situações já vividas com maior facilidade, melhorando suas tomadas de decisão.";
                }
                else
                {
                    lblResultado.Visible = true;
                    lblResultado.Text = "Você não se encaixa em nenhum "; 
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message + "Algo deu Errado");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblDoutorEstranho_Click(object sender, EventArgs e)
        {

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
    }
}
