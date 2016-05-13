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
    public partial class Compra : Form
    {
        ArrayList notaFiscal;
        ArrayList notaFiscalItens;
        ArrayList estoque;
        public Compra()
        {
            InitializeComponent();
        }
        public Compra(ArrayList notaFiscal, ArrayList notaFiscalItens, ArrayList estoque)
        {
            this.notaFiscal = notaFiscal;
            this.notaFiscalItens = notaFiscalItens;
            this.estoque = estoque;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncluirProdutoNota fProdutoNota = new IncluirProdutoNota(notaFiscalItens, estoque);
            fProdutoNota.ShowDialog();
            listView1.Visible = false;
            listView1.Visible = true;
        }

        private void listView1_VisibleChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            if (listView1.Visible)
            {
                ListViewItem item = new ListViewItem();
                float tot = 0;

                foreach (ItensNotaFiscal i in notaFiscalItens)
                {
                    item = new ListViewItem(new[] { i.getCodigo().ToString(),
                                                            i.getDescricao(),
                                                            i.getQuantidade().ToString(),
                                                            i.getUnitario().ToString(),
                                                            i.getTotal().ToString()
                                                            });
                    tot = tot + i.getTotal();
                    listView1.Items.Add(item);
                }
                textBoxValorTotal.Text = tot.ToString();
            }

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                int n = 0;
                int nDelete = 0;
                float tot = 0;
                while (n < listView1.Items.Count)
                {
    //                MessageBox.Show("item " + n.ToString());
    //                MessageBox.Show(listView1.Items[n].Index.ToString());
                    if (listView1.Items[n].Selected)
                    {
                        nDelete = n;
                    }
                    else
                    {
                        tot = tot + float.Parse(listView1.Items[n].SubItems[4].Text);
                    }
                    n++;
                }
                listView1.Items.Remove(listView1.Items[nDelete]);
                notaFiscalItens.RemoveAt(nDelete);
                textBoxValorTotal.Text = tot.ToString();
            }
            else
            {
                MessageBox.Show("Não temos itens para serem excluidos...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotaFiscal nNota = new NotaFiscal();
            nNota.setNumero(uint.Parse(textBoxNumero.Text));
            nNota.setDataEmissao(DateTime.Parse(textBoxEmissao.Text));
            nNota.setFornecedor(textBoxFornecedor.Text);
            nNota.setTipo('E');
            nNota.setValor(float.Parse(textBoxValorTotal.Text));
            nNota.setListaProdutos(notaFiscalItens);
            notaFiscal.Add(nNota);
            Close();
        }
    }
}
