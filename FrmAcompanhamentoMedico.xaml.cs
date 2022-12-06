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
            btnAcompanhamentoConsumoD_Agua.Visibility = Visibility.Hidden;
            btnAcompanhamentoGlicose.Visibility = Visibility.Hidden;
            btnAcompanhamentoPressao.Visibility = Visibility.Hidden;
            btnAcompanhamentoVacinas.Visibility = Visibility.Hidden;
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

        private void AbrirTelaDeAcompanhamentoDeGlicose(object sender, RoutedEventArgs e)
        {
            FrmSubAcompanhamentoGlicose frmAcompanhamentoGlicose = new FrmSubAcompanhamentoGlicose();
            frmAcompanhamentoGlicose.Show();
            Close();
        }

        private void AbrirTelaDeAcompanhamentoDePressao(object sender, RoutedEventArgs e)
        {
            FrmSubAcompanhamentoPressao frmAcompanhamentoPressao = new FrmSubAcompanhamentoPressao();
            frmAcompanhamentoPressao.Show();
            Close();
        }

        private void AbrirTelaDeAcompanhamentoDeVacinas(object sender, RoutedEventArgs e)
        {
            FrmSubCompanhamentoVacinas frmAcompanhamentoVacinas = new FrmSubCompanhamentoVacinas();
            frmAcompanhamentoVacinas.Show();
            Close();
        }

        private void AbrirTelaDeAcompanhamentoConsumoDeAgua(object sender, RoutedEventArgs e)
        {
            FrmSubAcompanhamentoAgua frmAcompanhamentoAgua = new FrmSubAcompanhamentoAgua();
            frmAcompanhamentoAgua.Show();
            Close();
        }
    }
}
