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
    /// Lógica interna para FrmClinicasEContatos.xaml
    /// </summary>
    public partial class FrmClinicasEContatos : Window
    {
        public FrmClinicasEContatos()
        {
            InitializeComponent();
        }

        private void AbrirBarraDeTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Visible;
            btnFecharBarra.Visibility = Visibility.Visible;
            btnTelaPrincipal.Visibility = Visibility.Visible;
            btnForum.Visibility = Visibility.Visible;
            btnArtigos.Visibility = Visibility.Visible;
            btnPerfil.Visibility = Visibility.Visible;
        }

        private void FecharBarraTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Hidden;
            btnAbrirBarra.Visibility = Visibility.Hidden;
            btnTelaPrincipal.Visibility = Visibility.Hidden;
            btnForum.Visibility = Visibility.Hidden;
            btnArtigos.Visibility = Visibility.Hidden;
            btnPerfil.Visibility = Visibility.Hidden;

            btnAbrirBarra.Visibility = Visibility.Visible;
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirTelaForum(object sender, RoutedEventArgs e)
        {
            FrmTelaForum frmTelaDoForum = new FrmTelaForum();
            frmTelaDoForum.Show();
            Close();
        }

        private void AbrirTelaArtigos(object sender, RoutedEventArgs e)
        {
            FrmTelaArtigos frmTelaDosArtigod = new FrmTelaArtigos();
            frmTelaDosArtigod.Show();
            Close();
        }

        private void AbrirTelaPerfil(object sender, RoutedEventArgs e)
        {
            FrmTelaPerfil frmTelaDePerfil = new FrmTelaPerfil();
            frmTelaDePerfil.Show();
            Close();
        }

        private void AbrirConversa(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa1(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa2(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa3(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa4(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa5(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa6(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa7(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa8(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }

        private void AbrirConversa9(object sender, RoutedEventArgs e)
        {
            FrmSubClinicasContatos frmTelaSubClinica = new FrmSubClinicasContatos();
            frmTelaSubClinica.Show();
            Close();
        }
    }
}
