using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas
{
    [Serializable]
    class Produto
    {
        uint codigo;
        string descricao;
        float valorUnitario;
        string unidade;
        uint estoque;
        public void setCodigo(uint codigo)
        {
            this.codigo = codigo;
        }
        public uint getCodigo()
        {
            return this.codigo;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setValorUnitario(float valorUnitario)
        {
            this.valorUnitario = valorUnitario;
        }
        public float getValorUnitario()
        {
            return this.valorUnitario;
        }
        public void setUnidade(string unidade)
        {
            this.unidade = unidade;
        }
        public string getUnidade()
        {
            return this.unidade;
        }
        public void setEstoque(uint estoque)
        {
            this.estoque = estoque;
        }
        public uint getEstoque()
        {
            return this.estoque;
        }
        public void entradaEstoque(uint estoque)
        {
            this.estoque += estoque;
        }
        public void saidaEstoque(uint estoque)
        {
            this.estoque -= estoque;
        }

    }
}
