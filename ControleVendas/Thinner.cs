using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas
{
    [Serializable]
    class Thinner : Produto
    {
        float densidade;
        string tipoAplicacao;

        public void setDensidade(float densidade)
        {
            this.densidade = densidade;
        }
        public void setTipoAplicacao(string tipoAplicacao)
        {
            this.tipoAplicacao = tipoAplicacao;
        }
        public float getDensidade()
        {
            return densidade;
        }
        public string getTipoAplicacao()
        {
            return tipoAplicacao;
        }

    }
}
