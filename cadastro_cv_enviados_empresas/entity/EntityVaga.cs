using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_cv_enviados_empresas.entity
{
    public class EntityVaga : EntityError
    {
        public int Id { get; set; }
        public int Data { get; set; }
        public string Descricao { get; set; }
        public string Empresa { get; set; }
        public string Email { get; set; }
        public string Obs { get; set; }

        public EntityVaga(int id, int data, string descricao, string empresa, string email, string obs)
        {
            Id = id;
            Data = data;
            Descricao = descricao;
            Empresa = empresa;
            Email = email;
            Obs = obs;
        }

        public EntityVaga()
        {
            Id = int.MinValue;
            Data = int.MinValue;
            Descricao = string.Empty;
            Empresa = string.Empty;
            Email = string.Empty;
            Obs = string.Empty;
        }
    }
}
