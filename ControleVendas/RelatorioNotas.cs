using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    public partial class RelatorioNotas : Form
    {
        ArrayList notasFiscais;
        public RelatorioNotas()
        {
            InitializeComponent();
        }

        public RelatorioNotas(ArrayList Compras)
        {
            InitializeComponent();
            this.notasFiscais = Compras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            string nl = Environment.NewLine;
            string nl2 = nl + nl;
            float total;

            textBox1.Clear();
            textBox1.Text = "Relatório das Notas Fiscal" + nl2;

            foreach (NotaFiscal i in notasFiscais)
            {
                total = 0;
                textBox1.Text += nl2+"Nota : " + i.getNumero() + " Emissao : " + i.getDataEmissao() + " Fornecedor : " + i.getFornecedor() + nl;
                foreach (ItensNotaFiscal z in i.getListaProdutos())
                {
                    textBox1.Text += "         Produto: " + z.getCodigo() + "  Descricao: " + z.getDescricao() + " Quant:" + z.getQuantidade() + " Valor: R$ " + String.Format(CultureInfo.InvariantCulture, "{0:0.00}", z.getTotal()) + nl;
                    total += z.getTotal();
                }
                textBox1.Text += "         Total da Nota: R$ " + String.Format(CultureInfo.InvariantCulture,"{0:0.00}", total)+nl;
            }
        }
    }
}
