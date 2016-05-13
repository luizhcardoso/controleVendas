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
    public partial class IncluirProdutoNota : Form
    {
        ArrayList notaFiscalItens;
//        CriaEstoque estoque;
        public IncluirProdutoNota()
        {
            InitializeComponent();
        }
        public IncluirProdutoNota(ArrayList notaFiscalItens)
        {
            InitializeComponent();
            this.notaFiscalItens = notaFiscalItens;
  //          this.estoque = estoque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItensNotaFiscal nItem = new ItensNotaFiscal();
            nItem.setCodigo(uint.Parse(textBoxCodigo.Text));
            nItem.setDescricao(textBoxDescricao.Text);
            nItem.setQuantidade(uint.Parse(textBoxQuantidade.Text));
            nItem.setUnitario(float.Parse(textBoxUnitario.Text));
            nItem.setTotal(float.Parse(textBoxTotal.Text));
            notaFiscalItens.Add(nItem);

            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodigo_Leave(object sender, EventArgs e)
        {

            CriaEstoque estoque = new CriaEstoque();
            estoque.Criar_Estoque();
            uint ver = 0;
            string descr="";
            string unit = "";
            string cod="";
            foreach (Produto i in estoque.getLista())
            {
                cod = i.getCodigo().ToString();
                if (cod.Equals(textBoxCodigo.Text))
                {
                    ver   = i.getCodigo();
                    descr = i.getDescricao();
                    unit  = i.getValorUnitario().ToString();
                }
                
            }
            if (ver.Equals(0))
            {
                MessageBox.Show("não encontrado!");
                textBoxCodigo.Focus();
            }
            else
            {
                textBoxDescricao.Text = descr;
                textBoxUnitario.Text = unit;
            }
        }

        private void textBoxQuantidade_Leave(object sender, EventArgs e)
        {
            float calc;
            if ((!textBoxQuantidade.Equals("")) && (!textBoxUnitario.Equals(""))){
                calc = uint.Parse(textBoxQuantidade.Text) * float.Parse(textBoxUnitario.Text);
                textBoxTotal.Text = calc.ToString();
             }
        }

        private void textBoxUnitario_Leave(object sender, EventArgs e)
        {
            float calc;
            if ((!textBoxQuantidade.Equals("")) && (!textBoxUnitario.Equals("")))
            {
                calc = uint.Parse(textBoxQuantidade.Text) * float.Parse(textBoxUnitario.Text);
                textBoxTotal.Text = calc.ToString();
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
