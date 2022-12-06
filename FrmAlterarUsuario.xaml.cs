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
    /// Lógica interna para FrmAlterarUsuario.xaml
    /// </summary>
    public partial class FrmAlterarUsuario : Window
    {
        public FrmAlterarUsuario()
        {
            InitializeComponent();
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            if(VerificarCampos() == true)
            {
                if(txtConfirmarNovaSenhaDoUsuario.Text == txtNovaSenhaDoUsuario.Text)
                {
                    string email = txtEmailDoUsuario.Text;
                    string senha = txtSenhaDoUsuario.Text;
                    bool validarAlteracao = ConsultasUsuario.AtualizarSenhaUsuario(email, senha);
                    if (validarAlteracao == true)
                    {
                        CaixaDeMensagem.ExibirMensagemUsuarioAtualizado();
                        AbrirTelaPrincipal();
                    }
                    else
                    {
                        CaixaDeMensagem.ExibirMensagemErroUsuarioAtualizado();
                    }

                }
                else
                {
                    CaixaDeMensagem.ExibirMensagemErroUsuarioCadastrado();
                }
            }
        }

        private bool VerificarCampos()
        {
            if (txtEmailDoUsuario.Text != "" && txtSenhaDoUsuario.Text != "" && txtNovaSenhaDoUsuario.Text != "" && txtConfirmarNovaSenhaDoUsuario.Text != "")
            {
                return true;
            }
            else
            {
                CaixaDeMensagem.ExibirMenssagemPreencherCampos();
                return false;
            }
        }
        private void AbrirTelaPrincipal()
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }
    }
}
