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
//        ArrayList Estoque = new ArrayList();
        static ArrayList Compras = new ArrayList();
        static ArrayList ItensCompras = new ArrayList();

        string fileEstoque = "Estoque1.xml";
        string fileCompras = "Compras1.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro fCadastro = new Cadastro();
            fCadastro.Show();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriaEstoque estoque = new CriaEstoque();
            estoque.Criar_Estoque();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileEstoque, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, estoque.getLista());
            stream.Close();

            stream = new FileStream(fileCompras, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Compras);
            stream.Close();

            MessageBox.Show("Dados Salvos para uso futuro...");
            Close();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio fRelatorio = new Relatorio();
            fRelatorio.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra fCompra = new Compra(Compras, ItensCompras);
            fCompra.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //            string fileEstoque = "Estoque1.xml";
            Stream stream;
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists(fileEstoque))
            {
                CriaEstoque estoque = new CriaEstoque();
                estoque.Criar_Estoque();

                stream = new FileStream(fileEstoque, FileMode.Open, FileAccess.Read, FileShare.Read);
                foreach (Produto i in (ArrayList)formatter.Deserialize(stream))
                {
                    estoque.Inclui(i);
                }
                stream.Close();
            }
            //            string fileCompras = "Compras1.xml";
            if (File.Exists(fileCompras))
            {
                stream = new FileStream(fileCompras, FileMode.Open, FileAccess.Read, FileShare.Read);
                Compras = (ArrayList)formatter.Deserialize(stream);
                stream.Close();
            }
            else
            {
                MessageBox.Show("Arquivo " + fileCompras + " não encontrado...");
            }

        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioNotas fRelatorio = new RelatorioNotas(Compras);
            fRelatorio.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cadastro fCadastro = new Cadastro();
            fCadastro.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Compra fCompra = new Compra(Compras, ItensCompras);
            fCompra.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            RelatorioNotas fRelatorio = new RelatorioNotas(Compras);
            fRelatorio.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Relatorio fRelatorio = new Relatorio();
            fRelatorio.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda.Show();
        }
    }
}
