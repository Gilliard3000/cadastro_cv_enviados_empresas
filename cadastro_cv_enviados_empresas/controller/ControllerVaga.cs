using cadastro_cv_enviados_empresas.business;
using cadastro_cv_enviados_empresas.common;
using cadastro_cv_enviados_empresas.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cv_enviados_empresas.controller
{
    public class ControllerVaga
    {
        public string AdicionarVaga(DateTime data, string descricao, string empresa, string email, string obs)
        {
            string resultadoOperacaoGravar = string.Empty;

            EntityVaga entityVaga = new EntityVaga();
            entityVaga.Descricao = descricao;
            entityVaga.Empresa = empresa;
            entityVaga.Email = email;
            entityVaga.Obs = obs;

            BusinessVaga businessVaga = new BusinessVaga();

            resultadoOperacaoGravar = businessVaga.AdicionarVaga(data, entityVaga);

            return resultadoOperacaoGravar;
        }


    }
}
