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

        private void AbrirConfigNoMenu(object sender, RoutedEventArgs e)
        {

        }

        private void FecharBarraMenu(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirBarraDeTarefas(object sender, RoutedEventArgs e)
        {

        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {

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

        private void FecharBarraTarefas(object sender, RoutedEventArgs e)
        {

        }
    }
}
