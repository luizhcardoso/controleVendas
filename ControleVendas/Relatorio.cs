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
        Form Venda;
        int valor = 0;

        private Venda venda = null;
        public Relatorio(Venda _venda)
        {
            this.venda = _venda;
            InitializeComponent();
        }
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            CriaEstoque estoque = new CriaEstoque();
            estoque.Criar_Estoque();

            ListViewItem item = new ListViewItem();
            float asDensidade;
            string asAplicacao;
            string asCor;
            
foreach (Produto i in estoque.getLista()) {
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                if (listView1.SelectedItems[0].Selected)
                {
                    Tinta t = new Tinta();
                    t.setCodigo(uint.Parse(listView1.FocusedItem.SubItems[0].Text));
                    t.setCor(listView1.FocusedItem.SubItems[1].Text);
                    t.setDescricao(listView1.FocusedItem.SubItems[2].Text);
                    t.setUnidade(listView1.FocusedItem.SubItems[3].Text);

                    venda.escreveListView("kkkkkkkk");
                    
                    
                    venda.Refresh();
    }


            }
            }

      public int getValor()
        {
            return valor;
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