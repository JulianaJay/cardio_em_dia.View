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
    /// Lógica interna para FrmSubTelaDeConversa.xaml
    /// </summary>
    public partial class FrmSubTelaDeConversa : Window
    {
        public FrmSubTelaDeConversa()
        {
            InitializeComponent();
        }

        private void VoltarParaClinicasEContatos(object sender, RoutedEventArgs e)
        {
            FrmClinicasEContatos frmClinicasEContatos = new FrmClinicasEContatos();
            frmClinicasEContatos.Show();
            Close();
        }
    }
}
