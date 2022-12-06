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
    /// Lógica interna para FrmAgenda.xaml
    /// </summary>
    public partial class FrmAgenda : Window
    {
        public FrmAgenda()
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
            btn1.Visibility = Visibility.Visible;
            btn2.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn3.Visibility = Visibility.Visible;
            btn4.Visibility = Visibility.Visible;
            btn5.Visibility = Visibility.Visible;
            btn6.Visibility = Visibility.Visible;
            btn7.Visibility = Visibility.Visible;
            btn8.Visibility = Visibility.Visible;
            btn9.Visibility = Visibility.Visible;
            btn10.Visibility = Visibility.Visible;
            btn11.Visibility = Visibility.Visible;
            btn12.Visibility = Visibility.Visible;
            btn13.Visibility = Visibility.Visible;
            btn14.Visibility = Visibility.Visible;
            btn15.Visibility = Visibility.Visible;
            btn16.Visibility = Visibility.Visible;
            btn17.Visibility = Visibility.Visible;
            btn18.Visibility = Visibility.Visible;
            btn19.Visibility = Visibility.Visible;
            btn20.Visibility = Visibility.Visible;
            btn21.Visibility = Visibility.Visible;
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

        private void AbrirBarraDeTarefas(object sender, RoutedEventArgs e)
        {
            imgBarraDeTarefas.Visibility = Visibility.Visible;
            btnFecharBarra.Visibility = Visibility.Visible;
            btnTelaPrincipal.Visibility = Visibility.Visible;
            btnForum.Visibility = Visibility.Visible;
            btnArtigos.Visibility = Visibility.Visible;
            btnPerfil.Visibility = Visibility.Visible;

            btn1.Visibility= Visibility.Hidden;
        }

        private void AbrirAgendaDoDia(object sender, RoutedEventArgs e)
        {
            //FrmSubAgendaDoDia frmAgendaDoDia = new FrmSubAgendaDoDia;
            //frmAgendaDoDia.Show();
            //Close();
        }
    }
}
