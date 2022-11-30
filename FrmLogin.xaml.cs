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
    /// Lógica interna para FrmLogin.xaml
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void LogarPeloGoogle(object sender, RoutedEventArgs e)
        {
            frmLoginPeloGoogle FrmLoginPeloGoogle = new frmLoginPeloGoogle();
            FrmLoginPeloGoogle.Show();
            Close();
        }

        private void LogarPeloFacebook(object sender, RoutedEventArgs e)
        {
            frmLoginPeloFacebook FrmLoginPeloFacebook = new frmLoginPeloFacebook();
            FrmLoginPeloFacebook.Show();
            Close();
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            if (VerificarCampos() == true)
            {
                string email = txtEmailDoUsuario.Text;
                string senha = txtSenhaDoUsuario.Text;
                Usuario usuario = ConsultasUsuario.ObterUsuario(email, senha);
                if (usuario != null)
                {
                    AbrirATelaPrincipal();
                }
                else
                {
                    CaixaDeMensagem.ExibirMensagemSenhaOuEmailIncorretos();
                }
            }
            else
            {
                CaixaDeMensagem.ExibirMenssagemPreencherCampos();
            }
        }

        private void AbrirTelaDeCadastro(object sender, RoutedEventArgs e)
        {
            AbrirATelaDeCadastro();
        }

        private void RecuperarSenha(object sender, MouseButtonEventArgs e)
        {
            //Topico não importante
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
        private void AbrirATelaPrincipal()
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }
        private void AbrirATelaDeCadastro()
        {
            FrmTelaDeCadastro_1 frmTelaDeCadastro1 = new FrmTelaDeCadastro_1();
            frmTelaDeCadastro1.Show();
            Close();
        }
    }
}
