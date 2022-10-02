using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cv_enviados_empresas.common
{
    public class CommonData
    {

        public static bool ValidarData(string dataInformada)
        {
            bool dataValidadaErro = false;

            try
            {
                DateTime dataConvertida = DateTime.Parse(dataInformada);
                dataValidadaErro = false;
            }
            catch
            {
                dataValidadaErro = true;
            }
            return dataValidadaErro;
        }

        public static DateTime ConverterData(string dataInformada)
        {
            DateTime dataConvertida = DateTime.Parse(dataInformada);
            
            return dataConvertida;
        }

    }
}
