using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    class CriaEstoque
    {
        private static Estoque x;

        public Estoque Criar_Estoque()
        {
            if (x == null)
            {
                    x = new Estoque();
                    return x;
            }
            else
            {
                return x;
            }
        }

        public void Inclui(Produto produto)
        {
            x.Add(produto);
        }
        public ArrayList getLista()
        {
            return x.getEstoque();
        }
        public void MovimentaEstoque(char tipomov, uint produto, uint quantidade)
        {
            x.setMovEstoque(tipomov, produto, quantidade);
        }
    }
}
