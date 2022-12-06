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
            FrmAcompanhamentoMedico frmAcompanhamentoMedico =  new FrmAcompanhamentoMedico();
            frmAcompanhamentoMedico.Show();
            Close();
        }

        private void AbrirDiario(object sender, RoutedEventArgs e)
        {
            FrmDiario FrmDiario = new FrmDiario();
            FrmDiario.Show();
            Close();
        }

        private void AbrirAgenda(object sender, RoutedEventArgs e)
        {
            FrmAgenda frmAgenda = new FrmAgenda();
            frmAgenda.Show();
            Close();
        }

        private void AbrirMeditação(object sender, RoutedEventArgs e)
        {
            FrmMeditacaoERelaxamento frmMeditacaoERelaxamento = new FrmMeditacaoERelaxamento();
            frmMeditacaoERelaxamento.Show();
            Close();
        }

        private void AbrirClinicasContatos(object sender, RoutedEventArgs e)
        {
            FrmClinicasEContatos frmClinicasEContatos = new FrmClinicasEContatos();
            frmClinicasEContatos.Show();
            Close();
        }

        private void AbrirDietaSaude(object sender, RoutedEventArgs e)
        {
            FrmDietaESaude frmDietaESaude = new FrmDietaESaude();
            frmDietaESaude.Show();
            Close();
        }

        private void FecharBarraMenu(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Hidden;
            btnAbrirBarra.Visibility = Visibility.Hidden;
            btnTelaPrincipal.Visibility = Visibility.Hidden;
            btnForum.Visibility = Visibility.Hidden;
            btnArtigos.Visibility = Visibility.Hidden;
            btnPerfil.Visibility = Visibility.Hidden;

            btnAbrirBarra.Visibility = Visibility.Visible;
            btnAcompanhamento.Visibility = Visibility.Visible;
            btnAgenda.Visibility = Visibility.Visible;
            btnDiario.Visibility = Visibility.Visible;
            btnMeditacao.Visibility = Visibility.Visible;
            btnDietaSaude.Visibility = Visibility.Visible;
            btnClinicas.Visibility = Visibility.Visible;
        }

        private void AbrirBarraDeTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Visible;
            btnFecharBarra.Visibility = Visibility.Visible;
            btnTelaPrincipal.Visibility = Visibility.Visible;
            btnForum.Visibility = Visibility.Visible;
            btnArtigos.Visibility = Visibility.Visible;
            btnPerfil.Visibility = Visibility.Visible;

            btnAcompanhamento.Visibility = Visibility.Hidden; 
            btnAgenda.Visibility = Visibility.Hidden;
            btnDiario.Visibility = Visibility.Hidden;
            btnMeditacao.Visibility = Visibility.Hidden;
            btnDietaSaude.Visibility = Visibility.Hidden;   
            btnClinicas.Visibility = Visibility.Hidden; 
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

        private void FecharBarraTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Hidden;
            btnAbrirBarra.Visibility = Visibility.Hidden;
            btnTelaPrincipal.Visibility = Visibility.Hidden;
            btnForum.Visibility = Visibility.Hidden;
            btnArtigos.Visibility = Visibility.Hidden;
            btnPerfil.Visibility = Visibility.Hidden;

            btnAbrirBarra.Visibility = Visibility.Visible;
            btnAcompanhamento.Visibility = Visibility.Visible;
            btnAgenda.Visibility = Visibility.Visible;
            btnDiario.Visibility = Visibility.Visible;
            btnMeditacao.Visibility = Visibility.Visible;
            btnDietaSaude.Visibility = Visibility.Visible;
            btnClinicas.Visibility = Visibility.Visible;
        }
    }
}
