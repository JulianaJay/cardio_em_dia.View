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
    /// Lógica interna para FrmTelaPrincipal.xaml
    /// </summary>
    public partial class FrmTelaPrincipal : Window
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirAcompanhamento(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirDiario(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirAgenda(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirMeditação(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirClinicasContatos(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirDietaSaude(object sender, RoutedEventArgs e)
        {
            frmTelaDeObras FrmTelaDeObras = new frmTelaDeObras();
            FrmTelaDeObras.Show();
            Close();
        }

        private void AbrirConfigNoMenu(object sender, RoutedEventArgs e)
        {

        }
    }
}
