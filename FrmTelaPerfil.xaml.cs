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
    /// Lógica interna para FrmTelaPerfil.xaml
    /// </summary>
    public partial class FrmTelaPerfil : Window
    {
        public FrmTelaPerfil()
        {
            InitializeComponent();
        }

        private void AbrirPopUp(object sender, RoutedEventArgs e)
        {
            imgPopUp.Visibility = Visibility.Visible;
            brdBordaPopUp.Visibility = Visibility.Visible;
            btnVoltarParaATelaInicial.Visibility = Visibility.Visible;
            btnAlterarConta.Visibility = Visibility.Visible;
            btnExcluirConta.Visibility = Visibility.Visible;
            btnFecharPopUp.Visibility = Visibility.Visible;

            btnAbrirPopUp.Visibility= Visibility.Hidden;
        }

        private void VoltarParaATelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirTelaAlterarConta(object sender, RoutedEventArgs e)
        {
            FrmAlterarUsuario frmAlterarUsuario = new FrmAlterarUsuario();
            frmAlterarUsuario.Show();
            Close();
        }

        private void ExcluirConta(object sender, RoutedEventArgs e)
        {
            FrmExcluirUsuario frmExcluirUsuario = new FrmExcluirUsuario();
            frmExcluirUsuario.Show();
            Close();
        }

        private void FecharPopUp(object sender, RoutedEventArgs e)
        {
            imgPopUp.Visibility = Visibility.Hidden;
            brdBordaPopUp.Visibility = Visibility.Hidden;
            btnVoltarParaATelaInicial.Visibility = Visibility.Hidden;
            btnAlterarConta.Visibility = Visibility.Hidden;
            btnExcluirConta.Visibility = Visibility.Hidden;
            btnFecharPopUp.Visibility = Visibility.Hidden;

            btnAbrirPopUp.Visibility = Visibility.Visible;
        }
    }
}
