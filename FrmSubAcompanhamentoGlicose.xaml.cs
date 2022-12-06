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
    /// Lógica interna para FrmSubAcompanhamentoGlicose.xaml
    /// </summary>
    public partial class FrmSubAcompanhamentoGlicose : Window
    {
        public FrmSubAcompanhamentoGlicose()
        {
            InitializeComponent();
        }

        private void VoltarParaTelaDeAcompanhamentoMedico(object sender, RoutedEventArgs e)
        {
            FrmAcompanhamentoMedico frmAcompanhamentoMedico = new FrmAcompanhamentoMedico();
            frmAcompanhamentoMedico.Show();
            Close();
        }
    }
}
