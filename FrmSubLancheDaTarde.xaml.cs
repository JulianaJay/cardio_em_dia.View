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
    /// Lógica interna para FrmSubLancheDaTarde.xaml
    /// </summary>
    public partial class FrmSubLancheDaTarde : Window
    {
        public FrmSubLancheDaTarde()
        {
            InitializeComponent();
        }

        private void VoltarParaDiarioESaude(object sender, RoutedEventArgs e)
        {
            FrmDietaESaude frmDietaESaude = new FrmDietaESaude();
            frmDietaESaude.Show();
            Close();
        }

        private void DiaUmCafe(object sender, RoutedEventArgs e)
        {

        }

        private void DiaLancheT(object sender, RoutedEventArgs e)
        {

        }
    }
}
