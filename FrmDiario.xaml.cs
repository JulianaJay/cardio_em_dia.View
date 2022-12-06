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
    /// Lógica interna para FrmDiario.xaml
    /// </summary>
    public partial class FrmDiario : Window
    {
        public FrmDiario()
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

            btnAbrirBarra.Visibility = Visibility.Hidden;
            btn01.Visibility = Visibility.Hidden;
            btn02.Visibility = Visibility.Hidden;
            btn03.Visibility = Visibility.Hidden;   
            btn04.Visibility = Visibility.Hidden;
            btn05.Visibility = Visibility.Hidden;
            btn06.Visibility = Visibility.Hidden;
            btn07.Visibility = Visibility.Hidden;
            btn08.Visibility = Visibility.Hidden;
            btn09.Visibility = Visibility.Hidden;
            btn10.Visibility = Visibility.Hidden;
            btn11.Visibility = Visibility.Hidden;
            btn12.Visibility = Visibility.Hidden;
            btn13.Visibility = Visibility.Hidden;
            btn14.Visibility = Visibility.Hidden;
            btn15.Visibility = Visibility.Hidden;
            btn16.Visibility = Visibility.Hidden;
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
            btn01.Visibility = Visibility.Visible;
            btn02.Visibility = Visibility.Visible;
            btn03.Visibility = Visibility.Visible;
            btn04.Visibility = Visibility.Visible;
            btn05.Visibility = Visibility.Visible;
            btn06.Visibility = Visibility.Visible;
            btn07.Visibility = Visibility.Visible;
            btn08.Visibility = Visibility.Visible;
            btn09.Visibility = Visibility.Visible;
            btn10.Visibility = Visibility.Visible;
            btn11.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn13.Visibility = Visibility.Visible;
            btn14.Visibility = Visibility.Visible;
            btn15.Visibility = Visibility.Visible;
            btn16.Visibility = Visibility.Visible;
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

        private void AbrirDiarioDoDia(object sender, RoutedEventArgs e)
        {
            FrmSubDiarioDoDia frmDiarioDoDia = new FrmSubDiarioDoDia();
            frmDiarioDoDia.Show();
            Close();
        }
    }
}
