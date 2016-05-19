using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControleVendas
{
    public partial class Venda : Form
    {
      
        public int valor;
        public Venda(String a)
        {
            InitializeComponent();
            
        }
        public Venda()
        {
            InitializeComponent();
        }

        public void labelNumero_Click(object sender, EventArgs e)
        {

        }

        public void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio(this);
             relatorio.Show();
            Console.WriteLine("venda");
                              
            Console.WriteLine(valor);
        }
        public void setValor(int valor)
        {
            this.valor = valor;
        }

     

        public void textBoxEmissao_TextChanged(object sender, EventArgs e)
        {

        }

        void Venda_Load(object sender, Produto i)
        {
        

        }

        public void escreveListView(String i)
        {

            ListViewItem item = new ListViewItem(new[] { i,
                                                    i,
                                                   i,
                                                   i,
                                                   i,
                                                   });
            listView1.Items.Add(item);
        }
    }


       

}
