using cadastro_cv_enviados_empresas.common;
using cadastro_cv_enviados_empresas.controller;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace cadastro_cv_enviados_empresas
{
    public partial class FormVaga : Form
    {


        public FormVaga()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string resultadoOperacaoGravar;
            bool resultadoOperacaoValidarDataComErro;
            DateTime dataInformadaConvertida;

            string dataInformada = textBoxDataVaga.Text;
            string descricao = textBoxDescricao.Text;
            string empresa = textBoxEmpresa.Text;
            string email = textBoxEmail.Text;
            string obs = textBoxOBS.Text;

            resultadoOperacaoValidarDataComErro = CommonData.ValidarData(dataInformada);

            if (resultadoOperacaoValidarDataComErro)
            {
                MessageBox.Show(ResourceMensagens.ConverterDataFalha);
            }
            else
            {
                dataInformadaConvertida = CommonData.ConverterData(dataInformada);

                ControllerVaga controllerVaga = new ControllerVaga();

                resultadoOperacaoGravar = controllerVaga.AdicionarVaga(dataInformadaConvertida, descricao, empresa, email, obs);

                MessageBox.Show(resultadoOperacaoGravar);
            }

            



        }
    }
}