using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas
{
    [Serializable]
    class Tinta : Produto
    {
        float densidade;
        string cor;
        string tipoAplicacao;

        public void setDensidade(float densidade)
        {
            this.densidade = densidade;
        }
        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public void setTipoAplicacao(string tipoAplicacao)
        {
            this.tipoAplicacao = tipoAplicacao;
        }
        public float getDensidade()
        {
            return densidade;
        }
        public string getCor()
        {
            return cor;
        }
        public string getTipoAplicacao()
        {
            return tipoAplicacao;
        }
    }
}
