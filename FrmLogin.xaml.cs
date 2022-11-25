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
    /// Lógica interna para FrmLogin.xaml
    /// </summary>
    public partial class FrmLogin : Window
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void LogarPeloGoogle(object sender, RoutedEventArgs e)
        {
            //Topico não importante
        }

        private void LogarPeloFacebook(object sender, RoutedEventArgs e)
        {
            //Topico não importante
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirTelaDeCadastro(object sender, RoutedEventArgs e)
        {
            FrmTelaDeCadastro_1 frmTelaDeCadastro1 = new FrmTelaDeCadastro_1();
            frmTelaDeCadastro1.Show();
            Close();
        }

        private void RecuperarSenha(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
