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
    /// Lógica interna para FrmAcompanhamentoMedico.xaml
    /// </summary>
    public partial class FrmAcompanhamentoMedico : Window
    {
        public FrmAcompanhamentoMedico()
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
            btnAcompanhamentoConsumoD_Agua.Visibility = Visibility.Visible;
            btnAcompanhamentoGlicose.Visibility = Visibility.Visible;
            btnAcompanhamentoPressao.Visibility = Visibility.Visible;
            btnAcompanhamentoVacinas.Visibility = Visibility.Visible;
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal(); 
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirTelaForum(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaArtigos(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaPerfil(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaDeAcompanhamentoDeGlicose(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaDeAcompanhamentoDePressao(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaDeAcompanhamentoDeVacinas(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaDeAcompanhamentoConsumoDeAgua(object sender, RoutedEventArgs e)
        {

        }
    }
}
