using cadastro_cv_enviados_empresas.common;
using cadastro_cv_enviados_empresas.data;
using cadastro_cv_enviados_empresas.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cv_enviados_empresas.business
{
    public class BusinessVaga
    {
        public string AdicionarVaga(DateTime data, EntityVaga entityVaga)
        {
            string resultadoOperacaoGravar = string.Empty;

            entityVaga.Data = ConfigurarDataParaUnixEpoch(data);

            DataVaga dataVaga = new DataVaga();

            resultadoOperacaoGravar = dataVaga.AdicionarVaga(entityVaga);

            return resultadoOperacaoGravar;
        }

        private Int32 ConfigurarDataParaUnixEpoch(DateTime dataInformada)
        {

            Int32 dataUnix;
            DateTime unixEpoch = new DateTime(1970, 1, 1);
            dataUnix = (Int32)(dataInformada.Subtract(unixEpoch)).TotalSeconds;

            return dataUnix;
        }

    }
}
