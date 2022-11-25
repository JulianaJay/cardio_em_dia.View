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
    /// Lógica interna para FrmTelaDeLogin.xaml
    /// </summary>
    public partial class FrmTelaDeLogin : Window
    {
        public FrmTelaDeLogin()
        {
            
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
    }
}