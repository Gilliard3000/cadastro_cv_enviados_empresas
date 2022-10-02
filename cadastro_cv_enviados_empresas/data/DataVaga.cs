using cadastro_cv_enviados_empresas.common;
using cadastro_cv_enviados_empresas.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cv_enviados_empresas.data
{
    public class DataVaga
    {

        public string AdicionarVaga(EntityVaga entityVaga)
        {
            string resultadoOperacaoGravar = string.Empty;

            CommonConexaoBD conexao = new CommonConexaoBD();

            resultadoOperacaoGravar = conexao.AdicionarVaga(entityVaga);

            return resultadoOperacaoGravar;
        }

    }
}
