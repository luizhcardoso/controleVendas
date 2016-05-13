using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            label8.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriaEstoque estoque = new CriaEstoque();
            estoque.Criar_Estoque();

            if (radioButton1.Checked)
            {
                Tinta pTinta = new Tinta();
                pTinta.setCodigo(uint.Parse(textBox1.Text));
                pTinta.setDescricao(textBox2.Text);
                pTinta.setValorUnitario(float.Parse(textBox4.Text));
                pTinta.setUnidade(textBox3.Text);
                pTinta.setDensidade(float.Parse(textBox6.Text));
                pTinta.setTipoAplicacao(textBox5.Text);
                pTinta.setCor(textBox8.Text);
                pTinta.setEstoque(0);
                estoque.Inclui(pTinta);
                textBox8.Text = "";
            }
            else
            {
                Thinner pThinner = new Thinner();
                pThinner.setCodigo(uint.Parse(textBox1.Text));
                pThinner.setDescricao(textBox2.Text);
                pThinner.setValorUnitario(float.Parse(textBox4.Text));
                pThinner.setUnidade(textBox3.Text);
                pThinner.setDensidade(float.Parse(textBox6.Text));
                pThinner.setTipoAplicacao(textBox5.Text);
                pThinner.setEstoque(0);
                estoque.Inclui(pThinner);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = false;
            label8.Visible = false;
        }
    }
}
