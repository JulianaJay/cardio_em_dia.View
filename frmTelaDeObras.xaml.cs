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
    /// Lógica interna para frmTelaDeObras.xaml
    /// </summary>
    public partial class frmTelaDeObras : Window
    {
        public frmTelaDeObras()
        {
            InitializeComponent();
        }

        private void btnVoltarParaMenu(object sender, MouseButtonEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }

        private void AbrirConfigNasObras(object sender, RoutedEventArgs e)
        {

        }
    }
}
