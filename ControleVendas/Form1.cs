using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ControleVendas
{
    public partial class Form1 : Form
    {
        ArrayList Estoque = new ArrayList();
        ArrayList Compras = new ArrayList();
        ArrayList ItensCompras = new ArrayList();

        string fileEstoque = "Estoque1.xml";
        string fileCompras = "Compras1.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro fCadastro = new Cadastro(Estoque);
            fCadastro.Show();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileEstoque, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.Estoque);
            stream.Close();

            stream = new FileStream(fileCompras, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.Compras);
            stream.Close();

            MessageBox.Show("Serialização concluida...");
            Close();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio fRelatorio = new Relatorio(Estoque);
            fRelatorio.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra fCompra = new Compra(Compras, ItensCompras, Estoque);
            fCompra.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            string fileEstoque = "Estoque1.xml";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileEstoque, FileMode.Open, FileAccess.Read, FileShare.Read);
            this.Estoque = (ArrayList)formatter.Deserialize(stream);
            stream.Close();

//            string fileCompras = "Compras1.xml";
            stream = new FileStream(fileCompras, FileMode.Open, FileAccess.Read, FileShare.Read);
            this.Compras = (ArrayList)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
