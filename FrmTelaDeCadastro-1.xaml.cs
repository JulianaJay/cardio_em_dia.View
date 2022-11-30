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
    /// Lógica interna para FrmTelaDeCadastro_1.xaml
    /// </summary>
    public partial class FrmTelaDeCadastro_1 : Window
    {
        public FrmTelaDeCadastro_1()
        {
            InitializeComponent();
        }

        private void CadastrarPeloGoogle(object sender, RoutedEventArgs e)
        {
            frmLoginPeloGoogle frmGoogle = new frmLoginPeloGoogle();
            frmGoogle.Show();
        }

        private void CadastrarPeloFacebook(object sender, RoutedEventArgs e)
        {
            frmLoginPeloFacebook frmFacebook = new frmLoginPeloFacebook();
            frmFacebook.Show();
        }

        private void AbrirTelaDeLogin(object sender, RoutedEventArgs e)
        {
            AbrirATelaDeLogin();
        }

        private void AbrirTelaDeCadastro2(object sender, RoutedEventArgs e)
        {
            if (VerificarCampos() == true)
            {
                string email = txtEmailCadastro.Text;
                string senha = txtSenhaCadastro.Text;
                bool usuarioExiste = ConsultasUsuario.VerificarUsuarioExistente(email);
                if (usuarioExiste == false)
                {
                    bool validarCadastro = ConsultasUsuario.NovoUsuario(email, senha);
                    if (validarCadastro == true)
                    {
                        CaixaDeMensagem.ExibirMensagemUsuarioCadastrado();
                        AbrirATelaDeCadastro2();
                    }
                    else
                    {
                        CaixaDeMensagem.ExibirMensagemErroUsuarioCadastrado();
                    }
                }
                else
                {
                    CaixaDeMensagem.ExibirMensagemEmailJaExisteNoSistema();
                }
            }

        }

        private bool VerificarCampos()
        {
            if (txtEmailCadastro.Text != "" && txtSenhaCadastro.Text != "" && txtConfirmarSenhaCadastro.Text != "")
            {
                return true;
            }
            else
            {
                CaixaDeMensagem.ExibirMenssagemPreencherCampos();
                return false;
            }
        }
        private void AbrirATelaDeCadastro2()
        {
            FrmTelaDeCadastro_2 frmTelaDeCadastro2 = new FrmTelaDeCadastro_2();
            frmTelaDeCadastro2.Show();
            Close();
        }
        private void AbrirATelaDeLogin()
        {
            FrmLogin frmTelaDeLogin = new FrmLogin();
            frmTelaDeLogin.Show();
            Close();
        }
    }
}
