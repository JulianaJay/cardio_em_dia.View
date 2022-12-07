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
    /// Lógica interna para frmLoginPeloGoogle.xaml
    /// </summary>
    public partial class frmLoginPeloGoogle : Window
    {
        public frmLoginPeloGoogle()
        {
            InitializeComponent();
        }

        private void VoltarAoLogin(object sender, RoutedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }

        private void IrAoCadastro(object sender, MouseButtonEventArgs e)
        {
            FrmTelaDeCadastro_1 frmCadastro = new FrmTelaDeCadastro_1();
            frmCadastro.Show();
            Close();
        }
    }
}
