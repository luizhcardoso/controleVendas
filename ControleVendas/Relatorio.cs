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
    public partial class Relatorio : Form
    {
        ArrayList Estoque;
        public Relatorio()
        {
            InitializeComponent();
        }
        public Relatorio(ArrayList Estoque)
        {
            this.Estoque = Estoque;
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();
            float asDensidade;
            string asAplicacao;
            string asCor;
            foreach (Produto i in Estoque) {
                {
                    if (i is Tinta)
                    {
                        asDensidade = (i as Tinta).getDensidade();
                        asAplicacao = (i as Tinta).getTipoAplicacao();
                        asCor = (i as Tinta).getCor();
                    }
                    else
                    {
                        asDensidade = (i as Thinner).getDensidade();
                        asAplicacao = (i as Thinner).getTipoAplicacao();
                        asCor = "";
                    }

                    item = new ListViewItem(new[] { i.getCodigo().ToString(),
                                                    i.getDescricao(),
                                                    i.getValorUnitario().ToString(),
                                                    i.getUnidade(),
                                                    i.getEstoque().ToString(),
                                                    asDensidade.ToString(),
                                                    asAplicacao,
                                                    asCor
                                                   });
                    listView1.Items.Add(item);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}





/*

public partial class Form2 : Form
{
    ArrayList ArrayAnterior;
    public Form2(ArrayList Array1)
    {
        InitializeComponent();
        ArrayAnterior = Array1;

        listView1.View = View.Details;
        listView1.Columns.Add("Codigo");
        listView1.Columns.Add("Descricao");
        listView1.Columns.Add("Unidade");
        listView1.Columns.Add("Valor");

        ListViewItem item = new ListViewItem();

        foreach (Produto a in ArrayAnterior)
        {
            item = new ListViewItem(new[] { a.getCodigo().ToString(),
                                                a.getDescricao(),
                                                a.getUnidade().ToString(),
                                                a.getValor().ToString() });
            listView1.Items.Add(item);

        }
    }

    private void Form2_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

}
*/