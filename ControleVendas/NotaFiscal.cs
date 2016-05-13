using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas
{
    [Serializable]
    class NotaFiscal
    {
        uint numero;
        char tipo;
        DateTime dataEmissao;
        string fornecedor;
        ArrayList listaProdutos;
        float valor;

        public NotaFiscal()
        {
            listaProdutos = new ArrayList();
        }
        public void setNumero(uint numero)
        {
            this.numero = numero;
        }
        public void setTipo(char tipo)
        {
            this.tipo = tipo;
        }
        public void setDataEmissao(DateTime dataEmissao)
        {
            this.dataEmissao = dataEmissao;
        }
        public void setFornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;
        }
        public void setValor(float valor)
        {
            this.valor = valor;
        }

        public uint getNumero()
        {
            return this.numero;
        }
        public char getTipo()
        {
            return this.tipo;
        }
        public DateTime getDataEmissao()
        {
            return this.dataEmissao;
        }
        public string getFornecedor()
        {
            return this.fornecedor;
        }
        public float getValor()
        {
            return this.valor;
        }
        public void setListaProdutos(ArrayList listaProdutos)
        {
            foreach(ItensNotaFiscal a in listaProdutos)
            {
                this.listaProdutos.Add(a);
            }
        }

        public ArrayList getListaProdutos()
        {
            return this.listaProdutos;
        }

    }
}
