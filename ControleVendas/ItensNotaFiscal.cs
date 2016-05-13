using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas
{
    [Serializable]
    class ItensNotaFiscal
    {
        uint numero;
        uint codigo;
        string descricao;
        uint quantidade;
        float unitario;
        float total;

        public void setNumero(uint numero)
        {
            this.numero = numero;
        }
        public void setCodigo(uint codigo)
        {
            this.codigo = codigo;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public void setQuantidade(uint quantidade)
        {
            this.quantidade = quantidade;
        }
        public void setUnitario(float unitario)
        {
            this.unitario = unitario;
        }
        public void setTotal(float total)
        {
            this.total = total;
        }
        public uint getNumero()
        {
            return this.numero;
        }
        public uint getCodigo()
        {
            return this.codigo;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public uint getQuantidade()
        {
            return this.quantidade;
        }
        public float getUnitario()
        {
            return this.unitario;
        }
        public float getTotal()
        {
            return this.total;
        }

    }
}
