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
            //Topico não importante
        }

        private void CadastrarPeloFacebook(object sender, RoutedEventArgs e)
        {
            //Topico não importante
        }

        private void AbrirTelaDeLogin(object sender, RoutedEventArgs e)
        {
            FrmLogin frmTelaDeLogin = new FrmLogin();
            frmTelaDeLogin.Show();
            Close();
        }

        private void AbrirTelaDeCadastro2(object sender, RoutedEventArgs e)
        {
            FrmTelaDeCadastro_2 frmTelaDeCadastro2 = new FrmTelaDeCadastro_2();
            frmTelaDeCadastro2.Show();
            Close();
        }

        private void ConfirmarPrimeiraParteDoCadastro()
        {
            if(txtEmailCadastro.Text != "" && txtSenhaCadastro.Text != "" && txtConfirmarSenhaCadastro.Text != "")
            {
                FrmTelaDeCadastro_2 frmTelaDeCadastro2 = new FrmTelaDeCadastro_2();
                frmTelaDeCadastro2.Show();
                Close();
            }
            else
            {
                CaixaDeMensagem.ExibirMenssagemPreencherCampos();
            }
        }
    }
}
