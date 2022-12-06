using cardio_em_dia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cardio_em_dia
{
    /// <summary>
    /// Lógica interna para FrmExcluirUsuario.xaml
    /// </summary>
    public partial class FrmExcluirUsuario : Window
    {
        public FrmExcluirUsuario()
        {
            InitializeComponent();
        }

        private void ExcluirUsuario(object sender, RoutedEventArgs e)
        {
            if (VerificarCampos() == true)
            {
                string email = txtEmailDoUsuario.Text;
                bool validarExclusao = ConsultasUsuario.ExcluirUsuario(email);
                if (validarExclusao == true)
                {
                    CaixaDeMensagem.ExibirMensagemUsuarioExcluido();
                    AbrirTelaDeCadastro();
                }
                else
                { 
                    CaixaDeMensagem.ExibirMensagemErroUsuarioExcluido();
                }
            }
        }
        private bool VerificarCampos()
            {
                if (txtEmailDoUsuario.Text != "" && txtSenhaDoUsuario.Text != "")
                {
                    return true;
                }
                else
                {
                    CaixaDeMensagem.ExibirMenssagemPreencherCampos();
                    return false;
                }
            }
        private void AbrirTelaDeCadastro()
        {
            FrmTelaDeCadastro_1 frmTelaDeCadastro_1 = new FrmTelaDeCadastro_1();
            frmTelaDeCadastro_1.Show();
            Close();
        }
    }
}
