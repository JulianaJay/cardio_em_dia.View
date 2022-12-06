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
    /// Lógica interna para FrmDietaESaude.xaml
    /// </summary>
    public partial class FrmDietaESaude : Window
    {
        public FrmDietaESaude()
        {
            InitializeComponent();
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
            btnCafeDaManha.Visibility = Visibility.Visible;
            btnLancheDaManha.Visibility = Visibility.Visible;
            btnAlmoco.Visibility = Visibility.Visible;
            btnLancheDaTarde.Visibility = Visibility.Visible;
            btnJantar.Visibility = Visibility.Visible;
            btnCeia.Visibility = Visibility.Visible;
        }

        private void AbrirTelaPerfil(object sender, RoutedEventArgs e)
        {
            FrmTelaPerfil frmTelaDePerfil = new FrmTelaPerfil();
            frmTelaDePerfil.Show();
            Close();
        }

        private void AbrirTelaArtigos(object sender, RoutedEventArgs e)
        {
            FrmTelaArtigos frmTelaDosArtigod = new FrmTelaArtigos();
            frmTelaDosArtigod.Show();
            Close();
        }

        private void AbrirTelaForum(object sender, RoutedEventArgs e)
        {
            FrmTelaForum frmTelaDoForum = new FrmTelaForum();
            frmTelaDoForum.Show();
            Close();
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirBarraDeTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Visible;
            btnFecharBarra.Visibility = Visibility.Visible;
            btnTelaPrincipal.Visibility = Visibility.Visible;
            btnForum.Visibility = Visibility.Visible;
            btnArtigos.Visibility = Visibility.Visible;
            btnPerfil.Visibility = Visibility.Visible;

            btnCafeDaManha.Visibility = Visibility.Hidden;
            btnLancheDaManha.Visibility = Visibility.Hidden;
            btnAlmoco.Visibility = Visibility.Hidden;
            btnLancheDaTarde.Visibility = Visibility.Hidden;
            btnJantar.Visibility = Visibility.Hidden;
            btnCeia.Visibility = Visibility.Hidden;
        }

        private void AbrirTelaCafeDaManha(object sender, RoutedEventArgs e)
        {
            //FrmSubCafeDaManha frmCafeDaManha = new FrmSubCafeDaManha;
            //frmCafeDaManha.Show();
            //Close();    
        }

        private void AbrirTelaLancheDaManha(object sender, RoutedEventArgs e)
        {
            //FrmSubLancheDaManha frmLancheDaManha = new FrmSubLancheDaManha;
            //frmLancheDaManha.Show();
            //Close();
        }

        private void AbrirTelaAlmoco(object sender, RoutedEventArgs e)
        {
            //FrmSubAlmoco frmAlmoco = new FrmSubAlmoco;
            //frmAlmoco.Show();
            //Close();
        }

        private void AbrirTelaLancheDaTarde(object sender, RoutedEventArgs e)
        {
            //FrmSubLancheDaTarde frmLancheDaTarde = new FrmSubLancheDaTarde;
            //frmLancheDaTarde.Shw();
            //Close();
        }

        private void AbrirTelaJantar(object sender, RoutedEventArgs e)
        {
            //FrmSubJantar frmJantar = new FrmSubJantar;
            //frmJantar.Show();
            //Close();
        }

        private void AbrirTelaCeia(object sender, RoutedEventArgs e)
        {
            //FrmSubCeia frmCeia = new FrmSubCeia;
            //frmCeia.Show();
            //Close();
        }
    }
}
