using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas
{
    class Estoque
    {

        ArrayList x = new ArrayList();

        public Estoque()
        {
        }
      
        public void Add(Produto p) 
        {
            x.Add(p);
        }

        public ArrayList getEstoque()
        {
            return this.x;
        }
        public void setMovEstoque(char tipomov, uint p, uint quantidade)
        {

            foreach (Produto i in this.x)
            {
                if (i.getCodigo() == p)
                {
                    if (tipomov == 'E')
                    {
                        i.entradaEstoque(quantidade);
                    }
                    else
                    {
                        i.saidaEstoque(quantidade);
                    }
                    break;
                }
            }
        }

    }
}

