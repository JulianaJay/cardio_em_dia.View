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
    /// Lógica interna para frmLoginPeloFacebook.xaml
    /// </summary>
    public partial class frmLoginPeloFacebook : Window
    {
        public frmLoginPeloFacebook()
        {
            InitializeComponent();
        }

        private void VoltarAoLogin(object sender, MouseButtonEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }

        private void BotaoFechar(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void VoltarAoLoginCelular(object sender, MouseButtonEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            Close();
        }
    }
}
